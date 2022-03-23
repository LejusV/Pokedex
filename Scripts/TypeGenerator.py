import os
import requests

# Load the API
endline: str = ",\n"
data = {}
response = requests.get("https://pokeapi.co/api/v2/type")
data = response.json()

# For each poke in the database
for typeLink in data["results"]:

    dataType = {}
    responseB = requests.get(f"{typeLink['url']}")
    dataType = responseB.json()

    # Temporary Variables
    typeName: str = dataType["name"].title()
    effect = dataType["damage_relations"]

    # If the file alreay exist, don't touch it
    if (os.path.isfile(f"Models\\PokemonTypes\\{typeName}.cs")): continue

    # Create the PokemonMove class, by opening a file
    newpath = f'./Models/PokemonTypes'
    if not os.path.exists(newpath):
        os.makedirs(newpath)
    with open(f"Models\\PokemonTypes\\{typeName}.cs", 'w', encoding="utf-8") as f:
    #with open(f"Models\\Moves\\{pokeType}\\Move{pokeNameNoSpace}.cs", 'w+', encoding="utf-8") as f:
        # Load the template code
        outfile = f"""

using System.Collections.Generic;

namespace Pokedex.Models.Types
{{
    public class {typeName} : PokemonType
    {{
        #region Variables
        private static {typeName}? _instance = null;
        #endregion

        #region Attributes
        public static {typeName} Instance
        {{
            get
            {{
                if (_instance == null)
                {{
                    _instance = new {typeName}();
                }}
                return _instance;
            }}
        }}
        #endregion

        #region Constructor
        private {typeName}() : base("{typeName}", new Dictionary<PokemonType, double>()
                {{
                    {r'''
                    '''.join([f"{{ {element['name'].title()}.Instance, 0 }}," for element in effect['no_damage_to']])}
                    {r'''
                    '''.join([f"{{ {element['name'].title()}.Instance, 0.5 }}," for element in effect['half_damage_to']])}
                    {r'''
                    '''.join([f"{{ {element['name'].title()}.Instance, 2 }}," for element in effect['double_damage_to']])}
                }})
        {{ }}
        #endregion
    }}
}}

"""[2:-2]
            # ↑ Delete the first two and last two newlines, here for readability

            # Write the code to the file
        f.write(outfile)