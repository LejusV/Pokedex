using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Castform Specie to store common natural stats of every {'abilities': ['forecast'], 'base_experience': 147, 'height': 3, 'id': 351, 'moves': ['headbutt', 'tackle', 'body-slam', 'double-edge', 'disable', 'ember', 'flamethrower', 'water-gun', 'hydro-pump', 'ice-beam', 'blizzard', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'mimic', 'double-team', 'defense-curl', 'fire-blast', 'swift', 'amnesia', 'flash', 'rest', 'substitute', 'thief', 'snore', 'powder-snow', 'protect', 'icy-wind', 'sandstorm', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'hail', 'facade', 'secret-power', 'weather-ball', 'cosmic-power', 'shock-wave', 'water-pulse', 'natural-gift', 'tailwind', 'lucky-chant', 'guard-swap', 'last-resort', 'energy-ball', 'avalanche', 'captivate', 'ominous-wind', 'round', 'clear-smog', 'scald', 'hex', 'incinerate', 'reflect-type', 'retaliate', 'work-up', 'hurricane', 'confide'], 'name': 'castform', 'stats': {'hp': 70, 'attack': 70, 'defense': 70, 'special-attack': 70, 'special-defense': 70, 'speed': 70}, 'types': ['normal'], 'weight': 8, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 45, 'color': 'gray', 'shape': 'ball', 'habitat': 'grassland', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['fairy', 'indeterminate'], 'names': {'ja-Hrkt': 'ポワルン', 'roomaji': 'Powalen', 'ko': '캐스퐁', 'zh-Hant': '飄浮泡泡', 'fr': 'Morphéo', 'de': 'Formeo', 'es': 'Castform', 'it': 'Castform', 'en': 'Castform', 'ja': 'ポワルン', 'zh-Hans': '飘浮泡泡'}, 'genera': {'ja-Hrkt': 'てんきポケモン', 'ko': '날씨포켓몬', 'zh-Hant': '天氣寶可夢', 'fr': 'Pokémon Climat', 'de': 'Wetter', 'es': 'Pokémon Clima', 'it': 'Pokémon Meteo', 'en': 'Weather Pokémon', 'ja': 'てんきポケモン', 'zh-Hans': '天气宝可梦'}}
	public class SpecieCastform : PokemonSpecie
	{
#nullable enable
		private static SpecieCastform? _instance = null;
#nullable restore
        public static SpecieCastform Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCastform();
                }
                return _instance;
            }
        }

		public SpecieCastform() : base(
			"Castform",
			70, // HPs
			70, 70, // Attack & Defense
			70, 70, // Special Attack & Defense
			70			
		) {}
	}


	//Castform Pokemon Class
	public class Castform : Pokemon
	{

		public Castform(string nickname, int level)
		: base(
				351,
				SpecieCastform.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Castform() : base(
			351,
			SpecieCastform.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}