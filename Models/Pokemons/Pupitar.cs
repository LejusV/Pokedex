using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pupitar Specie to store common natural stats of every {'abilities': ['shed-skin'], 'base_experience': 144, 'height': 12, 'id': 247, 'moves': ['headbutt', 'body-slam', 'thrash', 'double-edge', 'leer', 'bite', 'hyper-beam', 'earthquake', 'dig', 'toxic', 'mimic', 'screech', 'double-team', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'spite', 'protect', 'scary-face', 'mud-slap', 'detect', 'outrage', 'sandstorm', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'ancient-power', 'rock-smash', 'uproar', 'torment', 'facade', 'taunt', 'superpower', 'brick-break', 'secret-power', 'rock-tomb', 'iron-defense', 'natural-gift', 'payback', 'rock-polish', 'dark-pulse', 'earth-power', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'smack-down', 'round', 'chip-away', 'retaliate', 'bulldoze', 'snarl', 'confide', 'power-up-punch'], 'name': 'pupitar', 'stats': {'hp': 70, 'attack': 84, 'defense': 70, 'special-attack': 65, 'special-defense': 70, 'speed': 51}, 'types': ['rock', 'ground'], 'weight': 1520, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'gray', 'shape': 'squiggle', 'habitat': 'mountain', 'generation': 'generation-ii', 'growth_rate': 'slow', 'egg_groups': ['monster'], 'names': {'ja-Hrkt': 'サナギラス', 'roomaji': 'Sanagiras', 'ko': '데기라스', 'zh-Hant': '沙基拉斯', 'fr': 'Ymphect', 'de': 'Pupitar', 'es': 'Pupitar', 'it': 'Pupitar', 'en': 'Pupitar', 'ja': 'サナギラス', 'zh-Hans': '沙基拉斯'}, 'genera': {'ja-Hrkt': 'だんがんポケモン', 'ko': '탄환포켓몬', 'zh-Hant': '子彈寶可夢', 'fr': 'Pokémon Carapadure', 'de': 'Hartschale', 'es': 'Pokémon Caparazón', 'it': 'Pokémon Guscioduro', 'en': 'Hard Shell Pokémon', 'ja': 'だんがんポケモン', 'zh-Hans': '子弹宝可梦'}}
	public class SpeciePupitar : PokemonSpecie
	{
#nullable enable
		private static SpeciePupitar? _instance = null;
#nullable restore
        public static SpeciePupitar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePupitar();
                }
                return _instance;
            }
        }

		public SpeciePupitar() : base(
			"Pupitar",
			70, // HPs
			84, 70, // Attack & Defense
			65, 70, // Special Attack & Defense
			51			
		) {}
	}


	//Pupitar Pokemon Class
	public class Pupitar : Pokemon
	{

		public Pupitar(string nickname, int level) : base(
			247,
			SpeciePupitar.Instance, // Pokemon Specie
			nickname, level,
			Rock.Instance, Ground.Instance			
		) {}

		public Pupitar() : base(
			247,
			SpeciePupitar.Instance, // Pokemon Specie
			Rock.Instance, Ground.Instance			
		) {}
	}
}