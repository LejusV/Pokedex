using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Suicune Specie to store common natural stats of every {'abilities': ['pressure', 'inner-focus'], 'base_experience': 261, 'height': 20, 'id': 245, 'moves': ['cut', 'gust', 'headbutt', 'body-slam', 'double-edge', 'leer', 'bite', 'roar', 'mist', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'aurora-beam', 'hyper-beam', 'dig', 'toxic', 'mimic', 'double-team', 'reflect', 'waterfall', 'swift', 'rest', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'icy-wind', 'detect', 'sandstorm', 'endure', 'swagger', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'mirror-coat', 'psych-up', 'shadow-ball', 'rock-smash', 'whirlpool', 'hail', 'facade', 'secret-power', 'dive', 'signal-beam', 'extrasensory', 'sheer-cold', 'calm-mind', 'water-pulse', 'brine', 'natural-gift', 'tailwind', 'giga-impact', 'avalanche', 'ice-fang', 'rock-climb', 'iron-head', 'ominous-wind', 'round', 'scald', 'quash', 'bulldoze', 'snarl', 'confide'], 'name': 'suicune', 'stats': {'hp': 100, 'attack': 75, 'defense': 115, 'special-attack': 90, 'special-defense': 115, 'speed': 85}, 'types': ['water'], 'weight': 1870, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 80, 'gender_rate': -1, 'capture_rate': 3, 'color': 'blue', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'スイクン', 'roomaji': 'Suikun', 'ko': '스이쿤', 'zh-Hant': '水君', 'fr': 'Suicune', 'de': 'Suicune', 'es': 'Suicune', 'it': 'Suicune', 'en': 'Suicune', 'ja': 'スイクン', 'zh-Hans': '水君'}, 'genera': {'ja-Hrkt': 'オーロラポケモン', 'ko': '오로라포켓몬', 'zh-Hant': '極光寶可夢', 'fr': 'Pokémon Aurore', 'de': 'Polarlicht', 'es': 'Pokémon Aurora', 'it': 'Pokémon Aurora', 'en': 'Aurora Pokémon', 'ja': 'オーロラポケモン', 'zh-Hans': '极光宝可梦'}}
	public class SpecieSuicune : PokemonSpecie
	{
#nullable enable
		private static SpecieSuicune? _instance = null;
#nullable restore
        public static SpecieSuicune Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSuicune();
                }
                return _instance;
            }
        }

		public SpecieSuicune() : base(
			"Suicune",
			100, // HPs
			75, 115, // Attack & Defense
			90, 115, // Special Attack & Defense
			85			
		) {}
	}


	//Suicune Pokemon Class
	public class Suicune : Pokemon
	{

		public Suicune(string nickname, int level) : base(
			245,
			SpecieSuicune.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Suicune() : base(
			245,
			SpecieSuicune.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}