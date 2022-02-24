using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Feebas Specie to store common natural stats of every {'abilities': ['swift-swim', 'oblivious', 'adaptability'], 'base_experience': 40, 'height': 6, 'id': 349, 'moves': ['tackle', 'double-edge', 'mist', 'surf', 'ice-beam', 'blizzard', 'toxic', 'hypnosis', 'mimic', 'double-team', 'confuse-ray', 'light-screen', 'haze', 'waterfall', 'swift', 'splash', 'rest', 'substitute', 'snore', 'flail', 'protect', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'iron-tail', 'hidden-power', 'rain-dance', 'mirror-coat', 'whirlpool', 'hail', 'facade', 'secret-power', 'dive', 'mud-sport', 'tickle', 'water-pulse', 'brine', 'natural-gift', 'dragon-pulse', 'captivate', 'round', 'scald', 'confide'], 'name': 'feebas', 'stats': {'hp': 20, 'attack': 15, 'defense': 20, 'special-attack': 10, 'special-defense': 55, 'speed': 80}, 'types': ['water'], 'weight': 74, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'fish', 'habitat': 'waters-edge', 'generation': 'generation-iii', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['water1', 'dragon'], 'names': {'ja-Hrkt': 'ヒンバス', 'roomaji': 'Hinbass', 'ko': '빈티나', 'zh-Hant': '醜醜魚', 'fr': 'Barpau', 'de': 'Barschwa', 'es': 'Feebas', 'it': 'Feebas', 'en': 'Feebas', 'ja': 'ヒンバス', 'zh-Hans': '丑丑鱼'}, 'genera': {'ja-Hrkt': 'さかなポケモン', 'ko': '물고기포켓몬', 'zh-Hant': '魚寶可夢', 'fr': 'Pokémon Poisson', 'de': 'Fisch', 'es': 'Pokémon Pez', 'it': 'Pokémon Pesce', 'en': 'Fish Pokémon', 'ja': 'さかなポケモン', 'zh-Hans': '鱼宝可梦'}}
	public class SpecieFeebas : PokemonSpecie
	{
#nullable enable
		private static SpecieFeebas? _instance = null;
#nullable restore
        public static SpecieFeebas Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFeebas();
                }
                return _instance;
            }
        }

		public SpecieFeebas() : base(
			"Feebas",
			20, // HPs
			15, 20, // Attack & Defense
			10, 55, // Special Attack & Defense
			80			
		) {}
	}


	//Feebas Pokemon Class
	public class Feebas : Pokemon
	{

		public Feebas(string nickname, int level)
		: base(
				349,
				SpecieFeebas.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Feebas(int level)
		: base(
				349,
				SpecieFeebas.Instance, // Pokemon Specie
				"Feebas", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Feebas() : base(
			349,
			SpecieFeebas.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}