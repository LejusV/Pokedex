using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lampent Specie to store common natural stats of every {'abilities': ['flash-fire', 'flame-body', 'infiltrator'], 'base_experience': 130, 'height': 6, 'id': 608, 'moves': ['ember', 'flamethrower', 'solar-beam', 'fire-spin', 'toxic', 'psychic', 'night-shade', 'double-team', 'minimize', 'confuse-ray', 'smog', 'fire-blast', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'snore', 'curse', 'spite', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'sunny-day', 'psych-up', 'shadow-ball', 'heat-wave', 'will-o-wisp', 'memento', 'facade', 'taunt', 'trick', 'imprison', 'secret-power', 'astonish', 'overheat', 'calm-mind', 'shock-wave', 'payback', 'embargo', 'dark-pulse', 'energy-ball', 'trick-room', 'telekinesis', 'flame-burst', 'flame-charge', 'round', 'hex', 'incinerate', 'inferno', 'confide'], 'name': 'lampent', 'stats': {'hp': 60, 'attack': 40, 'defense': 60, 'special-attack': 95, 'special-defense': 60, 'speed': 55}, 'types': ['ghost', 'fire'], 'weight': 130, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'black', 'shape': 'arms', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ランプラー', 'ko': '램프라', 'zh-Hant': '燈火幽靈', 'fr': 'Mélancolux', 'de': 'Laternecto', 'es': 'Lampent', 'it': 'Lampent', 'en': 'Lampent', 'ja': 'ランプラー', 'zh-Hans': '灯火幽灵'}, 'genera': {'ja-Hrkt': 'ランプポケモン', 'ko': '램프포켓몬', 'zh-Hant': '油燈寶可夢', 'fr': 'Pokémon Lampe', 'de': 'Lampe', 'es': 'Pokémon Farolillo', 'it': 'Pokémon Lanterna', 'en': 'Lamp Pokémon', 'ja': 'ランプポケモン', 'zh-Hans': '油灯宝可梦'}}
	public class SpecieLampent : PokemonSpecie
	{
#nullable enable
		private static SpecieLampent? _instance = null;
#nullable restore
        public static SpecieLampent Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLampent();
                }
                return _instance;
            }
        }

		public SpecieLampent() : base(
			"Lampent",
			60, // HPs
			40, 60, // Attack & Defense
			95, 60, // Special Attack & Defense
			55			
		) {}
	}


	//Lampent Pokemon Class
	public class Lampent : Pokemon
	{

		public Lampent(string nickname, int level)
		: base(
				608,
				SpecieLampent.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Lampent() : base(
			608,
			SpecieLampent.Instance, // Pokemon Specie
			Ghost.Instance, Fire.Instance			
		) {}
	}
}