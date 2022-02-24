using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Solrock Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 161, 'height': 12, 'id': 338, 'moves': ['tackle', 'body-slam', 'double-edge', 'flamethrower', 'hyper-beam', 'solar-beam', 'fire-spin', 'rock-throw', 'earthquake', 'toxic', 'confusion', 'psychic', 'mimic', 'double-team', 'harden', 'defense-curl', 'light-screen', 'reflect', 'self-destruct', 'fire-blast', 'swift', 'dream-eater', 'flash', 'psywave', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'sandstorm', 'endure', 'rollout', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'sunny-day', 'psych-up', 'ancient-power', 'shadow-ball', 'heat-wave', 'will-o-wisp', 'facade', 'helping-hand', 'magic-coat', 'recycle', 'skill-swap', 'secret-power', 'overheat', 'rock-tomb', 'cosmic-power', 'signal-beam', 'iron-defense', 'calm-mind', 'gravity', 'gyro-ball', 'natural-gift', 'embargo', 'heal-block', 'flare-blitz', 'rock-polish', 'earth-power', 'giga-impact', 'zen-headbutt', 'trick-room', 'iron-head', 'stone-edge', 'stealth-rock', 'grass-knot', 'charge-beam', 'wonder-room', 'psyshock', 'telekinesis', 'smack-down', 'round', 'incinerate', 'acrobatics', 'bulldoze', 'confide'], 'name': 'solrock', 'stats': {'hp': 90, 'attack': 95, 'defense': 85, 'special-attack': 55, 'special-defense': 65, 'speed': 70}, 'types': ['rock', 'psychic'], 'weight': 1540, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': -1, 'capture_rate': 45, 'color': 'red', 'shape': 'ball', 'habitat': 'cave', 'generation': 'generation-iii', 'growth_rate': 'fast', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ソルロック', 'roomaji': 'Solrock', 'ko': '솔록', 'zh-Hant': '太陽岩', 'fr': 'Solaroc', 'de': 'Sonnfel', 'es': 'Solrock', 'it': 'Solrock', 'en': 'Solrock', 'ja': 'ソルロック', 'zh-Hans': '太阳岩'}, 'genera': {'ja-Hrkt': 'いんせきポケモン', 'ko': '별똥별포켓몬', 'zh-Hant': '隕石寶可夢', 'fr': 'Pokémon Météorite', 'de': 'Meteorit', 'es': 'Pokémon Meteorito', 'it': 'Pokémon Meteorite', 'en': 'Meteorite Pokémon', 'ja': 'いんせきポケモン', 'zh-Hans': '陨石宝可梦'}}
	public class SpecieSolrock : PokemonSpecie
	{
#nullable enable
		private static SpecieSolrock? _instance = null;
#nullable restore
        public static SpecieSolrock Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSolrock();
                }
                return _instance;
            }
        }

		public SpecieSolrock() : base(
			"Solrock",
			90, // HPs
			95, 85, // Attack & Defense
			55, 65, // Special Attack & Defense
			70			
		) {}
	}


	//Solrock Pokemon Class
	public class Solrock : Pokemon
	{

		public Solrock(string nickname, int level)
		: base(
				338,
				SpecieSolrock.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Solrock() : base(
			338,
			SpecieSolrock.Instance, // Pokemon Specie
			Rock.Instance, Psychic.Instance			
		) {}
	}
}