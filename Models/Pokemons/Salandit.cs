using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Salandit Specie to store common natural stats of every {'abilities': ['corrosion', 'oblivious'], 'base_experience': 64, 'height': 6, 'id': 757, 'moves': ['double-slap', 'scratch', 'sand-attack', 'ember', 'flamethrower', 'dragon-rage', 'toxic', 'double-team', 'smog', 'fire-blast', 'poison-gas', 'leech-life', 'rest', 'substitute', 'thief', 'protect', 'sludge-bomb', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'sweet-scent', 'hidden-power', 'fake-out', 'torment', 'will-o-wisp', 'facade', 'taunt', 'knock-off', 'snatch', 'overheat', 'dragon-claw', 'payback', 'fling', 'poison-jab', 'dragon-pulse', 'nasty-plot', 'shadow-claw', 'venoshock', 'flame-burst', 'sludge-wave', 'flame-charge', 'round', 'belch', 'confide', 'venom-drench'], 'name': 'salandit', 'stats': {'hp': 48, 'attack': 44, 'defense': 40, 'special-attack': 71, 'special-defense': 40, 'speed': 77}, 'types': ['poison', 'fire'], 'weight': 48, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 120, 'color': 'black', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'ヤトウモリ', 'ko': '야도뇽', 'zh-Hant': '夜盜火蜥', 'fr': 'Tritox', 'de': 'Molunk', 'es': 'Salandit', 'it': 'Salandit', 'en': 'Salandit', 'ja': 'ヤトウモリ', 'zh-Hans': '夜盗火蜥'}, 'genera': {'ja-Hrkt': 'どくトカゲポケモン', 'ko': '독도마뱀포켓몬', 'zh-Hant': '毒蜥寶可夢', 'fr': 'Pokémon Toxilézard', 'de': 'Giftechse', 'es': 'Pokémon Lagartoxina', 'it': 'Pokémon Lucertossina', 'en': 'Toxic Lizard Pokémon', 'ja': 'どくトカゲポケモン', 'zh-Hans': '毒蜥宝可梦'}}
	public class SpecieSalandit : PokemonSpecie
	{
#nullable enable
		private static SpecieSalandit? _instance = null;
#nullable restore
        public static SpecieSalandit Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSalandit();
                }
                return _instance;
            }
        }

		public SpecieSalandit() : base(
			"Salandit",
			48, // HPs
			44, 40, // Attack & Defense
			71, 40, // Special Attack & Defense
			77			
		) {}
	}


	//Salandit Pokemon Class
	public class Salandit : Pokemon
	{

		public Salandit(string nickname, int level)
		: base(
				757,
				SpecieSalandit.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Salandit() : base(
			757,
			SpecieSalandit.Instance, // Pokemon Specie
			Poison.Instance, Fire.Instance			
		) {}
	}
}