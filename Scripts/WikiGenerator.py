# Imports
import json
import os

# Load the json file
data = {}
with open("Data\\pokemon.json", encoding="utf-8") as F:
	data = json.load(F)

	# If the file alreay exist, don't touch it
	#if (os.path.isfile(f"Models\\Moves\\{pokeType}\\Move{pokeNameNoSpace}.cs")): continue
	nl = ",\n\t\t\t\t"

	# Create the PokemonMove class, by opening a file
	with open(f"Models\\Wiki.cs", 'w', encoding="utf-8") as f:
	#with open(f"Models\\Moves\\{pokeType}\\Move{pokeNameNoSpace}.cs", 'w+', encoding="utf-8") as f:
		# Load the template code
		outfile = f"""

using Pokedex.Models.Pokemons;
using System.Collections.Generic;

namespace Pokedex.Models
{{
    internal class Wiki
    {{
        
        private static Dictionary<int, PokemonInstance?>
        
         _pokemons;
        
        private static Wiki? _instance = null;
        public static Wiki Instance
        {{
            get
            {{
                if (_instance == null)
                {{
                    _instance = new Wiki();
                }}
                return _instance;
            }}
        }}

        public Dictionary<int, PokemonInstance?> Pokemons
        {{ get {{ return _pokemons; }} }} 


        public string Display()
        {{
            string res = "";
            foreach (KeyValuePair<int, PokemonInstance?> entry in this.Pokemons) 
            {{
                if (entry.Value != null)
                {{
                    res += string.Format("id " + entry.Key + "\\n" +
                    entry.Value.Specie.Name + "\\n" +
                    "Type" + entry.Value.TypesString + "\\n\\n");
                }}
            }}
            return res;
        }}

        public Wiki()
        {{
            #region PokemonDictionary
            _pokemons = new Dictionary<int, PokemonInstance?>()
            {{
				{nl.join([f'{{ {poke["id"]},		new {"".join([c for c in poke["name"].title() if c not in (" ", "-")]) }() }}' for poke in data.values()]) }
			}};
            #endregion
        }}
    }}
}}


"""[2:-2]
		# ↑ Delete the first two and last two newlines, here for readability

		# Write the code to the file
		f.write(outfile)