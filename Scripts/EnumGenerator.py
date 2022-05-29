# Imports
import json
import os
from unicodedata import category

# Load the json file
data = {}
with open("Data\\moves.json", encoding="utf-8") as f:
	data = json.load(f)

ailments = {}
eof: str = ",\n\t\t"

for move in data.values():
    moveAilment: str = move["ailment"]["type"].title()
    moveAilmentNoSpace: str = ''.join([c for c in moveAilment if c not in (' ', '-')])
    moveAilmentChance: int = move["ailment"]["chance"]
    ailments[moveAilmentNoSpace] = moveAilmentChance

with open(f"Enums\\MoveAilment.cs", 'w+', encoding="utf-8") as f:
    outfile = f"""

namespace Pokedex.Enums
{{
    public enum MoveAilment
    {{
        {eof.join(enum for enum in ailments.keys())}
    }}
}}

"""
    f.write(outfile)

targetTypes = {}

for move in data.values():
    moveTarget: str = move["target"].title()
    moveTargetNoSpace: str = ''.join([c for c in moveTarget if c not in (' ', '-')])
    targetTypes[moveTargetNoSpace] = 0

with open(f"Enums\\MoveTarget.cs", 'w+', encoding="utf-8") as f:
    outfile = f"""

namespace Pokedex.Enums
{{
    public enum MoveTarget
    {{
        {eof.join(enum for enum in targetTypes.keys())}
    }}
}}

"""
    f.write(outfile)


categories = {}

for move in data.values():
    moveCategory: str = move["category"].title()
    moveCategoryNoSpace: str = ''.join([c for c in moveCategory if c not in (' ', '-', '+')])
    categories[moveCategoryNoSpace] = 0

with open(f"Enums\\MoveCategory.cs", 'w+', encoding="utf-8") as fCat:
    outfile = f"""

namespace Pokedex.Enums
{{
    public enum MoveCategory
    {{
        {eof.join(enum for enum in categories.keys())}
    }}
}}

"""
    fCat.write(outfile)