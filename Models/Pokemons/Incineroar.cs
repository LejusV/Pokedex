using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Incineroar Specie to store common natural stats of every {'abilities': ['blaze', 'intimidate'], 'base_experience': 239, 'height': 18, 'id': 727, 'moves': ['scratch', 'swords-dance', 'double-kick', 'thrash', 'leer', 'bite', 'growl', 'roar', 'ember', 'flamethrower', 'hyper-beam', 'earthquake', 'toxic', 'double-team', 'lick', 'fire-blast', 'leech-life', 'fury-swipes', 'rest', 'substitute', 'protect', 'scary-face', 'outrage', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'cross-chop', 'sunny-day', 'torment', 'will-o-wisp', 'facade', 'taunt', 'brick-break', 'blast-burn', 'overheat', 'bulk-up', 'u-turn', 'embargo', 'fling', 'flare-blitz', 'dark-pulse', 'focus-blast', 'giga-impact', 'shadow-claw', 'fire-fang', 'flame-charge', 'low-sweep', 'round', 'quash', 'acrobatics', 'fire-pledge', 'bulldoze', 'work-up', 'snarl', 'confide', 'darkest-lariat', 'throat-chop', 'brutal-swing'], 'name': 'incineroar', 'stats': {'hp': 95, 'attack': 115, 'defense': 90, 'special-attack': 80, 'special-defense': 90, 'speed': 60}, 'types': ['fire', 'dark'], 'weight': 830, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 1, 'capture_rate': 45, 'color': 'red', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ガオガエン', 'ko': '어흥염', 'zh-Hant': '熾焰咆哮虎', 'fr': 'Félinferno', 'de': 'Fuegro', 'es': 'Incineroar', 'it': 'Incineroar', 'en': 'Incineroar', 'ja': 'ガオガエン', 'zh-Hans': '炽焰咆哮虎'}, 'genera': {'ja-Hrkt': 'ヒールポケモン', 'ko': '힐포켓몬', 'zh-Hant': '反派寶可夢', 'fr': 'Pokémon Vil Catcheur', 'de': 'Fiesling', 'es': 'Pokémon Rudo', 'it': 'Pokémon Colpibassi', 'en': 'Heel Pokémon', 'ja': 'ヒールポケモン', 'zh-Hans': '反派宝可梦'}}
	public class SpecieIncineroar : PokemonSpecie
	{
#nullable enable
		private static SpecieIncineroar? _instance = null;
#nullable restore
        public static SpecieIncineroar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieIncineroar();
                }
                return _instance;
            }
        }

		public SpecieIncineroar() : base(
			"Incineroar",
			95, // HPs
			115, 90, // Attack & Defense
			80, 90, // Special Attack & Defense
			60			
		) {}
	}


	//Incineroar Pokemon Class
	public class Incineroar : Pokemon
	{

		public Incineroar(string nickname, int level) : base(
			727,
			SpecieIncineroar.Instance, // Pokemon Specie
			nickname, level,
			Fire.Instance, Dark.Instance			
		) {}

		public Incineroar() : base(
			727,
			SpecieIncineroar.Instance, // Pokemon Specie
			Fire.Instance, Dark.Instance			
		) {}
	}
}