using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gardevoir Specie to store common natural stats of every {'abilities': ['synchronize', 'trace', 'telepathy'], 'base_experience': 233, 'height': 16, 'id': 282, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'headbutt', 'body-slam', 'double-edge', 'growl', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'toxic', 'confusion', 'psychic', 'hypnosis', 'teleport', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'swift', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'torment', 'will-o-wisp', 'facade', 'taunt', 'helping-hand', 'trick', 'wish', 'magic-coat', 'recycle', 'skill-swap', 'imprison', 'snatch', 'secret-power', 'hyper-voice', 'signal-beam', 'magical-leaf', 'calm-mind', 'shock-wave', 'healing-wish', 'natural-gift', 'fling', 'focus-blast', 'energy-ball', 'giga-impact', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'charge-beam', 'wonder-room', 'psyshock', 'telekinesis', 'magic-room', 'round', 'echoed-voice', 'stored-power', 'ally-switch', 'heal-pulse', 'disarming-voice', 'draining-kiss', 'misty-terrain', 'moonblast', 'confide', 'dazzling-gleam'], 'name': 'gardevoir', 'stats': {'hp': 68, 'attack': 65, 'defense': 65, 'special-attack': 125, 'special-defense': 115, 'speed': 80}, 'types': ['psychic', 'fairy'], 'weight': 484, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'white', 'shape': 'humanoid', 'habitat': 'urban', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'サーナイト', 'roomaji': 'Sirnight', 'ko': '가디안', 'zh-Hant': '沙奈朵', 'fr': 'Gardevoir', 'de': 'Guardevoir', 'es': 'Gardevoir', 'it': 'Gardevoir', 'en': 'Gardevoir', 'ja': 'サーナイト', 'zh-Hans': '沙奈朵'}, 'genera': {'ja-Hrkt': 'ほうようポケモン', 'ko': '포용포켓몬', 'zh-Hant': '包容寶可夢', 'fr': 'Pokémon Étreinte', 'de': 'Umarmung', 'es': 'Pokémon Envolvente', 'it': 'Pokémon Abbraccio', 'en': 'Embrace Pokémon', 'ja': 'ほうようポケモン', 'zh-Hans': '包容宝可梦'}}
	public class SpecieGardevoir : PokemonSpecie
	{
#nullable enable
		private static SpecieGardevoir? _instance = null;
#nullable restore
        public static SpecieGardevoir Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGardevoir();
                }
                return _instance;
            }
        }

		public SpecieGardevoir() : base(
			"Gardevoir",
			68, // HPs
			65, 65, // Attack & Defense
			125, 115, // Special Attack & Defense
			80			
		) {}
	}


	//Gardevoir Pokemon Class
	public class Gardevoir : Pokemon
	{

		public Gardevoir(string nickname, int level)
		: base(
				282,
				SpecieGardevoir.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Gardevoir() : base(
			282,
			SpecieGardevoir.Instance, // Pokemon Specie
			Psychic.Instance, Fairy.Instance			
		) {}
	}
}