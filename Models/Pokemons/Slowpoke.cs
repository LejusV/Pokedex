using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Slowpoke Specie to store common natural stats of every {'abilities': ['oblivious', 'own-tempo', 'regenerator'], 'base_experience': 63, 'height': 12, 'id': 79, 'moves': ['pay-day', 'stomp', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'growl', 'disable', 'flamethrower', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'strength', 'thunder-wave', 'earthquake', 'fissure', 'dig', 'toxic', 'confusion', 'psychic', 'rage', 'teleport', 'mimic', 'double-team', 'light-screen', 'reflect', 'bide', 'fire-blast', 'swift', 'skull-bash', 'amnesia', 'dream-eater', 'flash', 'psywave', 'rest', 'tri-attack', 'substitute', 'nightmare', 'snore', 'curse', 'protect', 'belly-drum', 'mud-slap', 'zap-cannon', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'whirlpool', 'hail', 'facade', 'trick', 'magic-coat', 'recycle', 'yawn', 'skill-swap', 'secret-power', 'dive', 'mud-sport', 'slack-off', 'signal-beam', 'block', 'calm-mind', 'water-pulse', 'brine', 'natural-gift', 'me-first', 'aqua-tail', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'wonder-room', 'psyshock', 'telekinesis', 'after-you', 'round', 'echoed-voice', 'scald', 'heal-pulse', 'incinerate', 'bulldoze', 'belch', 'confide'], 'name': 'slowpoke', 'stats': {'hp': 90, 'attack': 65, 'defense': 65, 'special-attack': 40, 'special-defense': 40, 'speed': 15}, 'types': ['water', 'psychic'], 'weight': 360, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'pink', 'shape': 'quadruped', 'habitat': 'waters-edge', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['monster', 'water1'], 'names': {'ja-Hrkt': 'ヤドン', 'roomaji': 'Yadon', 'ko': '야돈', 'zh-Hant': '呆呆獸', 'fr': 'Ramoloss', 'de': 'Flegmon', 'es': 'Slowpoke', 'it': 'Slowpoke', 'en': 'Slowpoke', 'ja': 'ヤドン', 'zh-Hans': '呆呆兽'}, 'genera': {'ja-Hrkt': 'まぬけポケモン', 'ko': '얼간이포켓몬', 'zh-Hant': '憨憨寶可夢', 'fr': 'Pokémon Crétin', 'de': 'Schnarcher', 'es': 'Pokémon Atontado', 'it': 'Pokémon Ronfone', 'en': 'Dopey Pokémon', 'ja': 'まぬけポケモン', 'zh-Hans': '憨憨宝可梦'}}
	public class SpecieSlowpoke : PokemonSpecie
	{
#nullable enable
		private static SpecieSlowpoke? _instance = null;
#nullable restore
        public static SpecieSlowpoke Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSlowpoke();
                }
                return _instance;
            }
        }

		public SpecieSlowpoke() : base(
			"Slowpoke",
			90, // HPs
			65, 65, // Attack & Defense
			40, 40, // Special Attack & Defense
			15			
		) {}
	}


	//Slowpoke Pokemon Class
	public class Slowpoke : Pokemon
	{

		public Slowpoke(string nickname, int level)
		: base(
				79,
				SpecieSlowpoke.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Slowpoke(int level)
		: base(
				79,
				SpecieSlowpoke.Instance, // Pokemon Specie
				"Slowpoke", level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Slowpoke() : base(
			79,
			SpecieSlowpoke.Instance, // Pokemon Specie
			Water.Instance, Psychic.Instance			
		) {}
	}
}