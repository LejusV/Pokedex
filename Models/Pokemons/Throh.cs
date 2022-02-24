using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Throh Specie to store common natural stats of every {'abilities': ['guts', 'inner-focus', 'mold-breaker'], 'base_experience': 163, 'height': 13, 'id': 538, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'bind', 'body-slam', 'leer', 'low-kick', 'seismic-toss', 'strength', 'earthquake', 'dig', 'toxic', 'double-team', 'focus-energy', 'bide', 'rest', 'rock-slide', 'substitute', 'snore', 'reversal', 'protect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'vital-throw', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'superpower', 'revenge', 'brick-break', 'knock-off', 'secret-power', 'rock-tomb', 'block', 'bulk-up', 'payback', 'fling', 'poison-jab', 'focus-blast', 'giga-impact', 'zen-headbutt', 'stone-edge', 'grass-knot', 'wide-guard', 'storm-throw', 'low-sweep', 'round', 'circle-throw', 'retaliate', 'bulldoze', 'work-up', 'mat-block', 'confide', 'power-up-punch'], 'name': 'throh', 'stats': {'hp': 120, 'attack': 100, 'defense': 85, 'special-attack': 30, 'special-defense': 85, 'speed': 45}, 'types': ['fighting'], 'weight': 555, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 0, 'capture_rate': 45, 'color': 'red', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'ナゲキ', 'ko': '던지미', 'zh-Hant': '投摔鬼', 'fr': 'Judokrak', 'de': 'Jiutesto', 'es': 'Throh', 'it': 'Throh', 'en': 'Throh', 'ja': 'ナゲキ', 'zh-Hans': '投摔鬼'}, 'genera': {'ja-Hrkt': 'じゅうどうポケモン', 'ko': '유도포켓몬', 'zh-Hant': '柔道寶可夢', 'fr': 'Pokémon Judo', 'de': 'Judo', 'es': 'Pokémon Judo', 'it': 'Pokémon Judo', 'en': 'Judo Pokémon', 'ja': 'じゅうどうポケモン', 'zh-Hans': '柔道宝可梦'}}
	public class SpecieThroh : PokemonSpecie
	{
#nullable enable
		private static SpecieThroh? _instance = null;
#nullable restore
        public static SpecieThroh Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieThroh();
                }
                return _instance;
            }
        }

		public SpecieThroh() : base(
			"Throh",
			120, // HPs
			100, 85, // Attack & Defense
			30, 85, // Special Attack & Defense
			45			
		) {}
	}


	//Throh Pokemon Class
	public class Throh : Pokemon
	{

		public Throh(string nickname, int level)
		: base(
				538,
				SpecieThroh.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Throh(int level)
		: base(
				538,
				SpecieThroh.Instance, // Pokemon Specie
				"Throh", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Throh() : base(
			538,
			SpecieThroh.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}