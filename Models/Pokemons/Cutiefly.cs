using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cutiefly Specie to store common natural stats of every {'abilities': ['honey-gather', 'shield-dust', 'sweet-veil'], 'base_experience': 61, 'height': 1, 'id': 742, 'moves': ['absorb', 'stun-spore', 'toxic', 'psychic', 'double-team', 'light-screen', 'reflect', 'dream-eater', 'leech-life', 'rest', 'substitute', 'thief', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'baton-pass', 'sweet-scent', 'hidden-power', 'sunny-day', 'psych-up', 'facade', 'skill-swap', 'aromatherapy', 'silver-wind', 'aerial-ace', 'calm-mind', 'roost', 'u-turn', 'bug-buzz', 'energy-ball', 'quiver-dance', 'round', 'acrobatics', 'bestow', 'struggle-bug', 'sticky-web', 'draining-kiss', 'fairy-wind', 'moonblast', 'confide', 'powder', 'dazzling-gleam', 'infestation', 'speed-swap'], 'name': 'cutiefly', 'stats': {'hp': 40, 'attack': 45, 'defense': 40, 'special-attack': 55, 'special-defense': 40, 'speed': 84}, 'types': ['bug', 'fairy'], 'weight': 2, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'yellow', 'shape': 'armor', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['bug', 'fairy'], 'names': {'ja-Hrkt': 'アブリー', 'ko': '에블리', 'zh-Hant': '萌虻', 'fr': 'Bombydou', 'de': 'Wommel', 'es': 'Cutiefly', 'it': 'Cutiefly', 'en': 'Cutiefly', 'ja': 'アブリー', 'zh-Hans': '萌虻'}, 'genera': {'ja-Hrkt': 'ツリアブポケモン', 'ko': '재니등에포켓몬', 'zh-Hant': '蜂虻寶可夢', 'fr': 'Pokémon Bombyle', 'de': 'Hummelfliege', 'es': 'Pokémon Mosca Abeja', 'it': 'Pokémon Bombilide', 'en': 'Bee Fly Pokémon', 'ja': 'ツリアブポケモン', 'zh-Hans': '蜂虻宝可梦'}}
	public class SpecieCutiefly : PokemonSpecie
	{
#nullable enable
		private static SpecieCutiefly? _instance = null;
#nullable restore
        public static SpecieCutiefly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCutiefly();
                }
                return _instance;
            }
        }

		public SpecieCutiefly() : base(
			"Cutiefly",
			40, // HPs
			45, 40, // Attack & Defense
			55, 40, // Special Attack & Defense
			84			
		) {}
	}


	//Cutiefly Pokemon Class
	public class Cutiefly : Pokemon
	{

		public Cutiefly(string nickname, int level)
		: base(
				742,
				SpecieCutiefly.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cutiefly() : base(
			742,
			SpecieCutiefly.Instance, // Pokemon Specie
			Bug.Instance, Fairy.Instance			
		) {}
	}
}