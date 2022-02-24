using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Victreebel Specie to store common natural stats of every {'abilities': ['chlorophyll', 'gluttony'], 'base_experience': 221, 'height': 17, 'id': 71, 'moves': ['swords-dance', 'cut', 'bind', 'vine-whip', 'body-slam', 'wrap', 'take-down', 'double-edge', 'acid', 'hyper-beam', 'mega-drain', 'razor-leaf', 'solar-beam', 'poison-powder', 'stun-spore', 'sleep-powder', 'toxic', 'rage', 'mimic', 'double-team', 'reflect', 'bide', 'flash', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'stockpile', 'spit-up', 'swallow', 'facade', 'nature-power', 'knock-off', 'secret-power', 'bullet-seed', 'leaf-blade', 'natural-gift', 'gastro-acid', 'worry-seed', 'sucker-punch', 'poison-jab', 'seed-bomb', 'energy-ball', 'giga-impact', 'leaf-storm', 'captivate', 'grass-knot', 'bug-bite', 'venoshock', 'round', 'leaf-tornado', 'confide', 'infestation'], 'name': 'victreebel', 'stats': {'hp': 80, 'attack': 105, 'defense': 65, 'special-attack': 100, 'special-defense': 70, 'speed': 70}, 'types': ['grass', 'poison'], 'weight': 155, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'green', 'shape': 'blob', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'ウツボット', 'roomaji': 'Utsubot', 'ko': '우츠보트', 'zh-Hant': '大食花', 'fr': 'Empiflor', 'de': 'Sarzenia', 'es': 'Victreebel', 'it': 'Victreebel', 'en': 'Victreebel', 'ja': 'ウツボット', 'zh-Hans': '大食花'}, 'genera': {'ja-Hrkt': 'ハエとりポケモン', 'ko': '파리잡이포켓몬', 'zh-Hant': '捕蠅寶可夢', 'fr': 'Pokémon Carnivore', 'de': 'Fliegentod', 'es': 'Pokémon Matamoscas', 'it': 'Pokémon Moschivoro', 'en': 'Flycatcher Pokémon', 'ja': 'ハエとりポケモン', 'zh-Hans': '捕蝇宝可梦'}}
	public class SpecieVictreebel : PokemonSpecie
	{
#nullable enable
		private static SpecieVictreebel? _instance = null;
#nullable restore
        public static SpecieVictreebel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVictreebel();
                }
                return _instance;
            }
        }

		public SpecieVictreebel() : base(
			"Victreebel",
			80, // HPs
			105, 65, // Attack & Defense
			100, 70, // Special Attack & Defense
			70			
		) {}
	}


	//Victreebel Pokemon Class
	public class Victreebel : Pokemon
	{

		public Victreebel(string nickname, int level)
		: base(
				71,
				SpecieVictreebel.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Victreebel(int level)
		: base(
				71,
				SpecieVictreebel.Instance, // Pokemon Specie
				"Victreebel", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Victreebel() : base(
			71,
			SpecieVictreebel.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
	}
}