using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rayquaza Specie to store common natural stats of every {'abilities': ['air-lock'], 'base_experience': 306, 'height': 70, 'id': 384, 'moves': ['swords-dance', 'fly', 'bind', 'headbutt', 'body-slam', 'double-edge', 'roar', 'flamethrower', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'mimic', 'double-team', 'fire-blast', 'waterfall', 'swift', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'scary-face', 'mud-slap', 'icy-wind', 'outrage', 'sandstorm', 'endure', 'swagger', 'fury-cutter', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'crunch', 'psych-up', 'extreme-speed', 'ancient-power', 'rock-smash', 'whirlpool', 'uproar', 'facade', 'brick-break', 'secret-power', 'dive', 'hyper-voice', 'overheat', 'rock-tomb', 'aerial-ace', 'dragon-claw', 'bulk-up', 'dragon-dance', 'shock-wave', 'water-pulse', 'gyro-ball', 'natural-gift', 'tailwind', 'fling', 'aqua-tail', 'air-slash', 'dragon-pulse', 'focus-blast', 'energy-ball', 'earth-power', 'giga-impact', 'avalanche', 'shadow-claw', 'draco-meteor', 'iron-head', 'stone-edge', 'hone-claws', 'round', 'echoed-voice', 'sky-drop', 'incinerate', 'bulldoze', 'dragon-tail', 'confide', 'dragon-ascent', 'brutal-swing'], 'name': 'rayquaza', 'stats': {'hp': 105, 'attack': 150, 'defense': 90, 'special-attack': 150, 'special-defense': 90, 'speed': 95}, 'types': ['dragon', 'flying'], 'weight': 2065, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 45, 'color': 'green', 'shape': 'squiggle', 'habitat': 'rare', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'レックウザ', 'roomaji': 'Rayquaza', 'ko': '레쿠쟈', 'zh-Hant': '烈空坐', 'fr': 'Rayquaza', 'de': 'Rayquaza', 'es': 'Rayquaza', 'it': 'Rayquaza', 'en': 'Rayquaza', 'ja': 'レックウザ', 'zh-Hans': '烈空坐'}, 'genera': {'ja-Hrkt': 'てんくうポケモン', 'ko': '천공포켓몬', 'zh-Hant': '天空寶可夢', 'fr': 'Pokémon Cieux', 'de': 'Himmelhoch', 'es': 'Pokémon Cielo', 'it': 'Pokémon Stratosfera', 'en': 'Sky High Pokémon', 'ja': 'てんくうポケモン', 'zh-Hans': '天空宝可梦'}}
	public class SpecieRayquaza : PokemonSpecie
	{
#nullable enable
		private static SpecieRayquaza? _instance = null;
#nullable restore
        public static SpecieRayquaza Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRayquaza();
                }
                return _instance;
            }
        }

		public SpecieRayquaza() : base(
			"Rayquaza",
			105, // HPs
			150, 90, // Attack & Defense
			150, 90, // Special Attack & Defense
			95			
		) {}
	}


	//Rayquaza Pokemon Class
	public class Rayquaza : Pokemon
	{

		public Rayquaza(string nickname, int level)
		: base(
				384,
				SpecieRayquaza.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Rayquaza() : base(
			384,
			SpecieRayquaza.Instance, // Pokemon Specie
			Dragon.Instance, Flying.Instance			
		) {}
	}
}