using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bagon Specie to store common natural stats of every {'abilities': ['rock-head', 'sheer-force'], 'base_experience': 60, 'height': 6, 'id': 371, 'moves': ['cut', 'headbutt', 'body-slam', 'thrash', 'double-edge', 'leer', 'bite', 'roar', 'ember', 'flamethrower', 'hydro-pump', 'strength', 'dragon-rage', 'toxic', 'rage', 'mimic', 'double-team', 'defense-curl', 'focus-energy', 'fire-blast', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'scary-face', 'mud-slap', 'outrage', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'crunch', 'rock-smash', 'facade', 'brick-break', 'secret-power', 'hyper-voice', 'rock-tomb', 'aerial-ace', 'dragon-claw', 'dragon-dance', 'natural-gift', 'dragon-pulse', 'dragon-rush', 'shadow-claw', 'fire-fang', 'zen-headbutt', 'draco-meteor', 'captivate', 'hone-claws', 'round', 'incinerate', 'confide'], 'name': 'bagon', 'stats': {'hp': 45, 'attack': 75, 'defense': 60, 'special-attack': 40, 'special-defense': 30, 'speed': 50}, 'types': ['dragon'], 'weight': 421, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'humanoid', 'habitat': 'rough-terrain', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['dragon'], 'names': {'ja-Hrkt': 'タツベイ', 'roomaji': 'Tatsubay', 'ko': '아공이', 'zh-Hant': '寶貝龍', 'fr': 'Draby', 'de': 'Kindwurm', 'es': 'Bagon', 'it': 'Bagon', 'en': 'Bagon', 'ja': 'タツベイ', 'zh-Hans': '宝贝龙'}, 'genera': {'ja-Hrkt': 'いしあたまポケモン', 'ko': '돌머리포켓몬', 'zh-Hant': '堅硬腦袋寶可夢', 'fr': 'Pokémon Tête de Roc', 'de': 'Steinhaupt', 'es': 'Pokémon Cabeza Roca', 'it': 'Pokémon Rocciotesta', 'en': 'Rock Head Pokémon', 'ja': 'いしあたまポケモン', 'zh-Hans': '坚硬脑袋宝可梦'}}
	public class SpecieBagon : PokemonSpecie
	{
#nullable enable
		private static SpecieBagon? _instance = null;
#nullable restore
        public static SpecieBagon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBagon();
                }
                return _instance;
            }
        }

		public SpecieBagon() : base(
			"Bagon",
			45, // HPs
			75, 60, // Attack & Defense
			40, 30, // Special Attack & Defense
			50			
		) {}
	}


	//Bagon Pokemon Class
	public class Bagon : Pokemon
	{

		public Bagon(string nickname, int level)
		: base(
				371,
				SpecieBagon.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Bagon(int level)
		: base(
				371,
				SpecieBagon.Instance, // Pokemon Specie
				"Bagon", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Bagon() : base(
			371,
			SpecieBagon.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
	}
}