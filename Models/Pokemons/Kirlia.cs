using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Kirlia Specie to store common natural stats of every {'abilities': ['synchronize', 'trace', 'telepathy'], 'base_experience': 97, 'height': 8, 'id': 281, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'headbutt', 'body-slam', 'double-edge', 'growl', 'thunderbolt', 'thunder-wave', 'toxic', 'confusion', 'psychic', 'hypnosis', 'teleport', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'swift', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'torment', 'will-o-wisp', 'facade', 'taunt', 'helping-hand', 'trick', 'magic-coat', 'recycle', 'skill-swap', 'imprison', 'snatch', 'secret-power', 'hyper-voice', 'signal-beam', 'magical-leaf', 'calm-mind', 'shock-wave', 'natural-gift', 'fling', 'lucky-chant', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'charge-beam', 'wonder-room', 'psyshock', 'telekinesis', 'magic-room', 'round', 'echoed-voice', 'stored-power', 'ally-switch', 'heal-pulse', 'disarming-voice', 'draining-kiss', 'confide', 'dazzling-gleam'], 'name': 'kirlia', 'stats': {'hp': 38, 'attack': 35, 'defense': 35, 'special-attack': 65, 'special-defense': 55, 'speed': 50}, 'types': ['psychic', 'fairy'], 'weight': 202, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'white', 'shape': 'humanoid', 'habitat': 'urban', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'キルリア', 'roomaji': 'Kirlia', 'ko': '킬리아', 'zh-Hant': '奇魯莉安', 'fr': 'Kirlia', 'de': 'Kirlia', 'es': 'Kirlia', 'it': 'Kirlia', 'en': 'Kirlia', 'ja': 'キルリア', 'zh-Hans': '奇鲁莉安'}, 'genera': {'ja-Hrkt': 'かんじょうポケモン', 'ko': '감정포켓몬', 'zh-Hant': '感情寶可夢', 'fr': 'Pokémon Émotion', 'de': 'Emotion', 'es': 'Pokémon Sensorio', 'it': 'Pokémon Emozione', 'en': 'Emotion Pokémon', 'ja': 'かんじょうポケモン', 'zh-Hans': '感情宝可梦'}}
	public class SpecieKirlia : PokemonSpecie
	{
#nullable enable
		private static SpecieKirlia? _instance = null;
#nullable restore
        public static SpecieKirlia Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKirlia();
                }
                return _instance;
            }
        }

		public SpecieKirlia() : base(
			"Kirlia",
			38, // HPs
			35, 35, // Attack & Defense
			65, 55, // Special Attack & Defense
			50			
		) {}
	}


	//Kirlia Pokemon Class
	public class Kirlia : Pokemon
	{

		public Kirlia(string nickname, int level) : base(
			281,
			SpecieKirlia.Instance, // Pokemon Specie
			nickname, level,
			Psychic.Instance, Fairy.Instance			
		) {}

		public Kirlia() : base(
			281,
			SpecieKirlia.Instance, // Pokemon Specie
			Psychic.Instance, Fairy.Instance			
		) {}
	}
}