using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Chandelure Specie to store common natural stats of every {'abilities': ['flash-fire', 'flame-body', 'infiltrator'], 'base_experience': 234, 'height': 10, 'id': 609, 'moves': ['flamethrower', 'hyper-beam', 'solar-beam', 'toxic', 'psychic', 'double-team', 'confuse-ray', 'smog', 'fire-blast', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'snore', 'spite', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'sunny-day', 'psych-up', 'shadow-ball', 'heat-wave', 'will-o-wisp', 'facade', 'taunt', 'trick', 'secret-power', 'overheat', 'calm-mind', 'shock-wave', 'payback', 'embargo', 'dark-pulse', 'energy-ball', 'giga-impact', 'trick-room', 'telekinesis', 'flame-burst', 'flame-charge', 'round', 'hex', 'incinerate', 'confide'], 'name': 'chandelure', 'stats': {'hp': 60, 'attack': 55, 'defense': 90, 'special-attack': 145, 'special-defense': 90, 'speed': 80}, 'types': ['ghost', 'fire'], 'weight': 343, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'black', 'shape': 'arms', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'シャンデラ', 'ko': '샹델라', 'zh-Hant': '水晶燈火靈', 'fr': 'Lugulabre', 'de': 'Skelabra', 'es': 'Chandelure', 'it': 'Chandelure', 'en': 'Chandelure', 'ja': 'シャンデラ', 'zh-Hans': '水晶灯火灵'}, 'genera': {'ja-Hrkt': 'いざないポケモン', 'ko': '권유포켓몬', 'zh-Hant': '引誘寶可夢', 'fr': 'Pokémon Invitation', 'de': 'Geleit', 'es': 'Pokémon Señuelo', 'it': 'Pokémon Attiranime', 'en': 'Luring Pokémon', 'ja': 'いざないポケモン', 'zh-Hans': '引诱宝可梦'}}
	public class SpecieChandelure : PokemonSpecie
	{
#nullable enable
		private static SpecieChandelure? _instance = null;
#nullable restore
        public static SpecieChandelure Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChandelure();
                }
                return _instance;
            }
        }

		public SpecieChandelure() : base(
			"Chandelure",
			60, // HPs
			55, 90, // Attack & Defense
			145, 90, // Special Attack & Defense
			80			
		) {}
	}


	//Chandelure Pokemon Class
	public class Chandelure : Pokemon
	{

		public Chandelure(string nickname, int level)
		: base(
				609,
				SpecieChandelure.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Chandelure() : base(
			609,
			SpecieChandelure.Instance, // Pokemon Specie
			Ghost.Instance, Fire.Instance			
		) {}
	}
}