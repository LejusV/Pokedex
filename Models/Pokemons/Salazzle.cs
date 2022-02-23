using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Salazzle Specie to store common natural stats of every {'abilities': ['corrosion', 'oblivious'], 'base_experience': 168, 'height': 12, 'id': 758, 'moves': ['pound', 'double-slap', 'disable', 'ember', 'flamethrower', 'dragon-rage', 'toxic', 'double-team', 'smog', 'fire-blast', 'poison-gas', 'leech-life', 'rest', 'substitute', 'thief', 'protect', 'sludge-bomb', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'encore', 'sweet-scent', 'hidden-power', 'torment', 'will-o-wisp', 'facade', 'taunt', 'overheat', 'dragon-claw', 'payback', 'fling', 'poison-jab', 'dragon-pulse', 'nasty-plot', 'shadow-claw', 'captivate', 'venoshock', 'flame-burst', 'sludge-wave', 'flame-charge', 'round', 'acrobatics', 'dragon-tail', 'confide', 'venom-drench'], 'name': 'salazzle', 'stats': {'hp': 68, 'attack': 64, 'defense': 60, 'special-attack': 111, 'special-defense': 60, 'speed': 117}, 'types': ['poison', 'fire'], 'weight': 222, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 45, 'color': 'black', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'エンニュート', 'ko': '염뉴트', 'zh-Hant': '焰后蜥', 'fr': 'Malamandre', 'de': 'Amfira', 'es': 'Salazzle', 'it': 'Salazzle', 'en': 'Salazzle', 'ja': 'エンニュート', 'zh-Hans': '焰后蜥'}, 'genera': {'ja-Hrkt': 'どくトカゲポケモン', 'ko': '독도마뱀포켓몬', 'zh-Hant': '毒蜥寶可夢', 'fr': 'Pokémon Toxilézard', 'de': 'Giftechse', 'es': 'Pokémon Lagartoxina', 'it': 'Pokémon Lucertossina', 'en': 'Toxic Lizard Pokémon', 'ja': 'どくトカゲポケモン', 'zh-Hans': '毒蜥宝可梦'}}
	public class SpecieSalazzle : PokemonSpecie
	{
#nullable enable
		private static SpecieSalazzle? _instance = null;
#nullable restore
        public static SpecieSalazzle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSalazzle();
                }
                return _instance;
            }
        }

		public SpecieSalazzle() : base(
			"Salazzle",
			68, // HPs
			64, 60, // Attack & Defense
			111, 60, // Special Attack & Defense
			117			
		) {}
	}


	//Salazzle Pokemon Class
	public class Salazzle : Pokemon
	{

		public Salazzle(string nickname, int level) : base(
			758,
			SpecieSalazzle.Instance, // Pokemon Specie
			nickname, level,
			Poison.Instance, Fire.Instance			
		) {}

		public Salazzle() : base(
			758,
			SpecieSalazzle.Instance, // Pokemon Specie
			Poison.Instance, Fire.Instance			
		) {}
	}
}