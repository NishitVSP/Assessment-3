import networkx as nx
import json

def analyze_dependencies(json_file):
    
    with open(json_file, 'r', encoding='utf-16') as f:  
        data = json.load(f)

    # Create directed graph
    G = nx.DiGraph()

    # Add nodes and edges with validation
    for module, details in data.items():
        if not isinstance(details, dict):
            continue
            
        G.add_node(module)
        
        if 'imports' in details:
            for imported_module in details['imports']:
                if imported_module in data:  # Only add edges for existing modules
                    G.add_edge(module, imported_module)

    # cycle detection
    cycles = list(nx.simple_cycles(G))
    
    print("\n=== Cyclic Dependency Analysis ===")
    print(f"Total cycles found: {len(cycles)}")
    
    if cycles:
        print("\nAll cyclic dependencies:")
        for i, cycle in enumerate(cycles):
            # Format cycle with arrow notation
            cycle_str = " → ".join(cycle) + f" → {cycle[0]}"
            print(f"Cycle {i+1}: {cycle_str}")
    else:
        print("No cyclic dependencies found")

    # Unused modules
    isolates = list(nx.isolates(G))
    print("\n=== Unused/Disconnected Modules ===")
    print(f"Found {len(isolates)} isolates" if isolates else "No unused modules found")
    if isolates:
        print("Isolated modules:\n" + "\n".join(isolates))

# Execute analysis
analyze_dependencies('ChatTTS.json')
