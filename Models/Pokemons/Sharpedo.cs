using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sharpedo Specie to store common natural stats of every {'abilities': ['rough-skin', 'speed-boost'], 'base_experience': 161, 'height': 18, 'id': 319, 'moves': ['double-edge', 'leer', 'bite', 'roar', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'earthquake', 'toxic', 'agility', 'rage', 'mimic', 'screech', 'double-team', 'focus-energy', 'waterfall', 'swift', 'skull-bash', 'rest', 'super-fang', 'slash', 'substitute', 'thief', 'snore', 'spite', 'protect', 'scary-face', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'crunch', 'ancient-power', 'rock-smash', 'whirlpool', 'uproar', 'hail', 'torment', 'facade', 'taunt', 'secret-power', 'dive', 'poison-fang', 'rock-tomb', 'bounce', 'water-pulse', 'brine', 'natural-gift', 'feint', 'payback', 'assurance', 'poison-jab', 'dark-pulse', 'night-slash', 'giga-impact', 'avalanche', 'ice-fang', 'zen-headbutt', 'captivate', 'aqua-jet', 'round', 'scald', 'retaliate', 'bulldoze', 'snarl', 'confide'], 'name': 'sharpedo', 'stats': {'hp': 70, 'attack': 120, 'defense': 40, 'special-attack': 95, 'special-defense': 40, 'speed': 95}, 'types': ['water', 'dark'], 'weight': 888, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'blue', 'shape': 'fish', 'habitat': 'sea', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['water2'], 'names': {'ja-Hrkt': 'サメハダー', 'roomaji': 'Samehader', 'ko': '샤크니아', 'zh-Hant': '巨牙鯊', 'fr': 'Sharpedo', 'de': 'Tohaido', 'es': 'Sharpedo', 'it': 'Sharpedo', 'en': 'Sharpedo', 'ja': 'サメハダー', 'zh-Hans': '巨牙鲨'}, 'genera': {'ja-Hrkt': 'きょうぼうポケモン', 'ko': '난폭포켓몬', 'zh-Hant': '凶暴寶可夢', 'fr': 'Pokémon Brutal', 'de': 'Brutal', 'es': 'Pokémon Voraz', 'it': 'Pokémon Brutale', 'en': 'Brutal Pokémon', 'ja': 'きょうぼうポケモン', 'zh-Hans': '凶暴宝可梦'}}
	public class SpecieSharpedo : PokemonSpecie
	{
#nullable enable
		private static SpecieSharpedo? _instance = null;
#nullable restore
        public static SpecieSharpedo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSharpedo();
                }
                return _instance;
            }
        }

		public SpecieSharpedo() : base(
			"Sharpedo",
			70, // HPs
			120, 40, // Attack & Defense
			95, 40, // Special Attack & Defense
			95			
		) {}
	}


	//Sharpedo Pokemon Class
	public class Sharpedo : Pokemon
	{

		public Sharpedo(string nickname, int level) : base(
			319,
			SpecieSharpedo.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance, Dark.Instance			
		) {}

		public Sharpedo() : base(
			319,
			SpecieSharpedo.Instance, // Pokemon Specie
			Water.Instance, Dark.Instance			
		) {}
	}
}