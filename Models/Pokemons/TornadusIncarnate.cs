using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tornadus-Incarnate Specie to store common natural stats of every {'abilities': ['prankster', 'defiant'], 'base_experience': 261, 'height': 15, 'id': 641, 'moves': ['gust', 'fly', 'thrash', 'bite', 'hyper-beam', 'strength', 'toxic', 'psychic', 'agility', 'double-team', 'rest', 'substitute', 'thief', 'snore', 'protect', 'sludge-bomb', 'icy-wind', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'crunch', 'rock-smash', 'uproar', 'heat-wave', 'torment', 'facade', 'taunt', 'role-play', 'superpower', 'revenge', 'brick-break', 'knock-off', 'secret-power', 'astonish', 'air-cutter', 'extrasensory', 'aerial-ace', 'bulk-up', 'hammer-arm', 'tailwind', 'u-turn', 'payback', 'embargo', 'fling', 'dark-pulse', 'air-slash', 'focus-blast', 'giga-impact', 'grass-knot', 'smack-down', 'sludge-wave', 'foul-play', 'round', 'sky-drop', 'incinerate', 'acrobatics', 'hurricane', 'confide', 'brutal-swing'], 'name': 'tornadus-incarnate', 'stats': {'hp': 79, 'attack': 115, 'defense': 70, 'special-attack': 125, 'special-defense': 80, 'speed': 111}, 'types': ['flying'], 'weight': 630, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': 0, 'capture_rate': 3, 'color': 'green', 'shape': 'arms', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'トルネロス', 'ko': '토네로스', 'zh-Hant': '龍捲雲', 'fr': 'Boréas', 'de': 'Boreos', 'es': 'Tornadus', 'it': 'Tornadus', 'en': 'Tornadus', 'ja': 'トルネロス', 'zh-Hans': '龙卷云'}, 'genera': {'ja-Hrkt': 'せんぷうポケモン', 'ko': '선풍포켓몬', 'zh-Hant': '旋風寶可夢', 'fr': 'Pokémon Tornade', 'de': 'Wirbelsturm', 'es': 'Pokémon Torbellino', 'it': 'Pokémon Turbinio', 'en': 'Cyclone Pokémon', 'ja': 'せんぷうポケモン', 'zh-Hans': '旋风宝可梦'}}
	public class SpecieTornadusIncarnate : PokemonSpecie
	{
#nullable enable
		private static SpecieTornadusIncarnate? _instance = null;
#nullable restore
        public static SpecieTornadusIncarnate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTornadusIncarnate();
                }
                return _instance;
            }
        }

		public SpecieTornadusIncarnate() : base(
			"Tornadus-Incarnate",
			79, // HPs
			115, 70, // Attack & Defense
			125, 80, // Special Attack & Defense
			111			
		) {}
	}


	//Tornadus-Incarnate Pokemon Class
	public class TornadusIncarnate : Pokemon
	{

		public TornadusIncarnate(string nickname, int level)
		: base(
				641,
				SpecieTornadusIncarnate.Instance, // Pokemon Specie
				nickname, level,
				Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public TornadusIncarnate() : base(
			641,
			SpecieTornadusIncarnate.Instance, // Pokemon Specie
			Flying.Instance			
		) {}
	}
}