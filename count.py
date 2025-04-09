import json
import csv

# Read the JSON file
with open("ChatTTS.json", 'r', encoding='utf-16') as f:
    data = json.load(f)

# Open a CSV file for writing
with open("ChatTTS_fan_in_out.csv", 'w', newline='', encoding='utf-8') as csvfile:
    writer = csv.writer(csvfile)
    
    # Write the header
    writer.writerow(["Module", "Fan-In", "Fan-Out"])
    
    # Write module data
    for module, details in data.items():
        fan_in = len(details.get('imports', []))
        fan_out = len(details.get('imported_by', []))
        writer.writerow([module, fan_in, fan_out])
        print(f"Module: {module}, Fan-In: {fan_in}, Fan-Out: {fan_out}")
