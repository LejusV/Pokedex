using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dusknoir Specie to store common natural stats of every {'abilities': ['pressure', 'frisk'], 'base_experience': 236, 'height': 22, 'id': 477, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'bind', 'headbutt', 'leer', 'disable', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'earthquake', 'toxic', 'psychic', 'night-shade', 'double-team', 'confuse-ray', 'dream-eater', 'flash', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'spite', 'protect', 'mud-slap', 'foresight', 'icy-wind', 'endure', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'rock-smash', 'torment', 'will-o-wisp', 'facade', 'focus-punch', 'taunt', 'trick', 'brick-break', 'skill-swap', 'snatch', 'secret-power', 'astonish', 'rock-tomb', 'shadow-punch', 'calm-mind', 'gravity', 'natural-gift', 'payback', 'embargo', 'fling', 'sucker-punch', 'dark-pulse', 'focus-blast', 'giga-impact', 'shadow-sneak', 'trick-room', 'captivate', 'charge-beam', 'ominous-wind', 'wonder-room', 'telekinesis', 'round', 'hex', 'bulldoze', 'confide', 'infestation', 'power-up-punch'], 'name': 'dusknoir', 'stats': {'hp': 45, 'attack': 100, 'defense': 135, 'special-attack': 65, 'special-defense': 135, 'speed': 45}, 'types': ['ghost'], 'weight': 1066, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 45, 'color': 'black', 'shape': 'arms', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'fast', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ヨノワール', 'roomaji': 'Yonoir', 'ko': '야느와르몽', 'zh-Hant': '黑夜魔靈', 'fr': 'Noctunoir', 'de': 'Zwirrfinst', 'es': 'Dusknoir', 'it': 'Dusknoir', 'en': 'Dusknoir', 'ja': 'ヨノワール', 'zh-Hans': '黑夜魔灵'}, 'genera': {'ja-Hrkt': 'てづかみポケモン', 'ko': '움켜쥠포켓몬', 'zh-Hant': '抓握寶可夢', 'fr': 'Pokémon Mainpince', 'de': 'Greifer', 'es': 'Pokémon Grilletes', 'it': 'Pokémon Pinza', 'en': 'Gripper Pokémon', 'ja': 'てづかみポケモン', 'zh-Hans': '抓握宝可梦'}}
	public class SpecieDusknoir : PokemonSpecie
	{
#nullable enable
		private static SpecieDusknoir? _instance = null;
#nullable restore
        public static SpecieDusknoir Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDusknoir();
                }
                return _instance;
            }
        }

		public SpecieDusknoir() : base(
			"Dusknoir",
			45, // HPs
			100, 135, // Attack & Defense
			65, 135, // Special Attack & Defense
			45			
		) {}
	}


	//Dusknoir Pokemon Class
	public class Dusknoir : Pokemon
	{

		public Dusknoir(string nickname, int level)
		: base(
				477,
				SpecieDusknoir.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dusknoir(int level)
		: base(
				477,
				SpecieDusknoir.Instance, // Pokemon Specie
				"Dusknoir", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dusknoir() : base(
			477,
			SpecieDusknoir.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
	}
}