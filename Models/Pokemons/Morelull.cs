using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Morelull Specie to store common natural stats of every {'abilities': ['illuminate', 'effect-spore', 'rain-dish'], 'base_experience': 57, 'height': 2, 'id': 755, 'moves': ['absorb', 'mega-drain', 'leech-seed', 'growth', 'solar-beam', 'poison-powder', 'stun-spore', 'sleep-powder', 'thunder-wave', 'toxic', 'double-team', 'confuse-ray', 'light-screen', 'amnesia', 'dream-eater', 'spore', 'flash', 'rest', 'substitute', 'protect', 'sludge-bomb', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'moonlight', 'hidden-power', 'sunny-day', 'nature-power', 'ingrain', 'astonish', 'energy-ball', 'grass-knot', 'round', 'moonblast', 'confide', 'dazzling-gleam', 'strength-sap', 'spotlight'], 'name': 'morelull', 'stats': {'hp': 40, 'attack': 35, 'defense': 55, 'special-attack': 65, 'special-defense': 75, 'speed': 15}, 'types': ['grass', 'fairy'], 'weight': 15, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'purple', 'shape': 'blob', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'ネマシュ', 'ko': '자마슈', 'zh-Hant': '睡睡菇', 'fr': 'Spododo', 'de': 'Bubungus', 'es': 'Morelull', 'it': 'Morelull', 'en': 'Morelull', 'ja': 'ネマシュ', 'zh-Hans': '睡睡菇'}, 'genera': {'ja-Hrkt': 'はっこうポケモン', 'ko': '발광포켓몬', 'zh-Hant': '發光寶可夢', 'fr': 'Pokémon Luminescent', 'de': 'Lumineszenz', 'es': 'Pokémon Luminiscente', 'it': 'Pokémon Luminescenza', 'en': 'Illuminating Pokémon', 'ja': 'はっこうポケモン', 'zh-Hans': '发光宝可梦'}}
	public class SpecieMorelull : PokemonSpecie
	{
#nullable enable
		private static SpecieMorelull? _instance = null;
#nullable restore
        public static SpecieMorelull Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMorelull();
                }
                return _instance;
            }
        }

		public SpecieMorelull() : base(
			"Morelull",
			40, // HPs
			35, 55, // Attack & Defense
			65, 75, // Special Attack & Defense
			15			
		) {}
	}


	//Morelull Pokemon Class
	public class Morelull : Pokemon
	{

		public Morelull(string nickname, int level)
		: base(
				755,
				SpecieMorelull.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Morelull(int level)
		: base(
				755,
				SpecieMorelull.Instance, // Pokemon Specie
				"Morelull", level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Morelull() : base(
			755,
			SpecieMorelull.Instance, // Pokemon Specie
			Grass.Instance, Fairy.Instance			
		) {}
	}
}