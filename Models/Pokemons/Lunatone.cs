using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lunatone Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 161, 'height': 10, 'id': 337, 'moves': ['tackle', 'body-slam', 'double-edge', 'ice-beam', 'blizzard', 'hyper-beam', 'rock-throw', 'earthquake', 'toxic', 'confusion', 'psychic', 'hypnosis', 'mimic', 'double-team', 'harden', 'defense-curl', 'light-screen', 'reflect', 'self-destruct', 'swift', 'dream-eater', 'flash', 'psywave', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'icy-wind', 'sandstorm', 'endure', 'rollout', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'rain-dance', 'psych-up', 'ancient-power', 'shadow-ball', 'future-sight', 'facade', 'helping-hand', 'magic-coat', 'recycle', 'skill-swap', 'secret-power', 'rock-tomb', 'cosmic-power', 'signal-beam', 'calm-mind', 'gravity', 'gyro-ball', 'natural-gift', 'embargo', 'heal-block', 'rock-polish', 'power-gem', 'earth-power', 'giga-impact', 'zen-headbutt', 'trick-room', 'iron-head', 'stone-edge', 'stealth-rock', 'grass-knot', 'charge-beam', 'psyshock', 'telekinesis', 'magic-room', 'smack-down', 'round', 'acrobatics', 'bulldoze', 'moonblast', 'confide'], 'name': 'lunatone', 'stats': {'hp': 90, 'attack': 55, 'defense': 65, 'special-attack': 95, 'special-defense': 85, 'speed': 70}, 'types': ['rock', 'psychic'], 'weight': 1680, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': -1, 'capture_rate': 45, 'color': 'yellow', 'shape': 'ball', 'habitat': 'cave', 'generation': 'generation-iii', 'growth_rate': 'fast', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ルナトーン', 'roomaji': 'Lunatone', 'ko': '루나톤', 'zh-Hant': '月石', 'fr': 'Séléroc', 'de': 'Lunastein', 'es': 'Lunatone', 'it': 'Lunatone', 'en': 'Lunatone', 'ja': 'ルナトーン', 'zh-Hans': '月石'}, 'genera': {'ja-Hrkt': 'いんせきポケモン', 'ko': '별똥별포켓몬', 'zh-Hant': '隕石寶可夢', 'fr': 'Pokémon Météorite', 'de': 'Meteorit', 'es': 'Pokémon Meteorito', 'it': 'Pokémon Meteorite', 'en': 'Meteorite Pokémon', 'ja': 'いんせきポケモン', 'zh-Hans': '陨石宝可梦'}}
	public class SpecieLunatone : PokemonSpecie
	{
#nullable enable
		private static SpecieLunatone? _instance = null;
#nullable restore
        public static SpecieLunatone Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLunatone();
                }
                return _instance;
            }
        }

		public SpecieLunatone() : base(
			"Lunatone",
			90, // HPs
			55, 65, // Attack & Defense
			95, 85, // Special Attack & Defense
			70			
		) {}
	}


	//Lunatone Pokemon Class
	public class Lunatone : Pokemon
	{

		public Lunatone(string nickname, int level)
		: base(
				337,
				SpecieLunatone.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Lunatone(int level)
		: base(
				337,
				SpecieLunatone.Instance, // Pokemon Specie
				"Lunatone", level,
				Rock.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Lunatone() : base(
			337,
			SpecieLunatone.Instance, // Pokemon Specie
			Rock.Instance, Psychic.Instance			
		) {}
	}
}