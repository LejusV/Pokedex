using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Ribombee Specie to store common natural stats of every {'abilities': ['honey-gather', 'shield-dust', 'sweet-veil'], 'base_experience': 162, 'height': 2, 'id': 743, 'moves': ['absorb', 'solar-beam', 'stun-spore', 'toxic', 'psychic', 'double-team', 'light-screen', 'reflect', 'dream-eater', 'leech-life', 'rest', 'substitute', 'thief', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'sweet-scent', 'hidden-power', 'sunny-day', 'psych-up', 'facade', 'nature-power', 'aromatherapy', 'silver-wind', 'aerial-ace', 'calm-mind', 'roost', 'u-turn', 'bug-buzz', 'energy-ball', 'quiver-dance', 'round', 'acrobatics', 'struggle-bug', 'draining-kiss', 'fairy-wind', 'confide', 'dazzling-gleam', 'infestation', 'pollen-puff'], 'name': 'ribombee', 'stats': {'hp': 60, 'attack': 55, 'defense': 60, 'special-attack': 95, 'special-defense': 70, 'speed': 124}, 'types': ['bug', 'fairy'], 'weight': 5, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'yellow', 'shape': 'bug-wings', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['bug', 'fairy'], 'names': {'ja-Hrkt': 'アブリボン', 'ko': '에리본', 'zh-Hant': '蝶結萌虻', 'fr': 'Rubombelle', 'de': 'Bandelby', 'es': 'Ribombee', 'it': 'Ribombee', 'en': 'Ribombee', 'ja': 'アブリボン', 'zh-Hans': '蝶结萌虻'}, 'genera': {'ja-Hrkt': 'ツリアブポケモン', 'ko': '재니등에포켓몬', 'zh-Hant': '蜂虻寶可夢', 'fr': 'Pokémon Bombyle', 'de': 'Hummelfliege', 'es': 'Pokémon Mosca Abeja', 'it': 'Pokémon Bombilide', 'en': 'Bee Fly Pokémon', 'ja': 'ツリアブポケモン', 'zh-Hans': '蜂虻宝可梦'}}
	public class SpecieRibombee : PokemonSpecie
	{
#nullable enable
		private static SpecieRibombee? _instance = null;
#nullable restore
        public static SpecieRibombee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRibombee();
                }
                return _instance;
            }
        }

		public SpecieRibombee() : base(
			"Ribombee",
			60, // HPs
			55, 60, // Attack & Defense
			95, 70, // Special Attack & Defense
			124			
		) {}
	}


	//Ribombee Pokemon Class
	public class Ribombee : Pokemon
	{

		public Ribombee(string nickname, int level)
		: base(
				743,
				SpecieRibombee.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ribombee() : base(
			743,
			SpecieRibombee.Instance, // Pokemon Specie
			Bug.Instance, Fairy.Instance			
		) {}
	}
}