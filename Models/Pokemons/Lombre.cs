using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lombre Specie to store common natural stats of every {'abilities': ['swift-swim', 'rain-dish', 'own-tempo'], 'base_experience': 119, 'height': 12, 'id': 271, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'swords-dance', 'headbutt', 'body-slam', 'double-edge', 'growl', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'strength', 'absorb', 'solar-beam', 'toxic', 'mimic', 'double-team', 'waterfall', 'bubble', 'flash', 'fury-swipes', 'rest', 'substitute', 'thief', 'snore', 'protect', 'mud-slap', 'icy-wind', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'synthesis', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'whirlpool', 'fake-out', 'uproar', 'hail', 'facade', 'nature-power', 'brick-break', 'knock-off', 'secret-power', 'dive', 'hyper-voice', 'astonish', 'bullet-seed', 'water-sport', 'water-pulse', 'natural-gift', 'fling', 'seed-bomb', 'drain-punch', 'energy-ball', 'zen-headbutt', 'captivate', 'grass-knot', 'hone-claws', 'round', 'echoed-voice', 'scald', 'confide', 'power-up-punch'], 'name': 'lombre', 'stats': {'hp': 60, 'attack': 50, 'defense': 50, 'special-attack': 60, 'special-defense': 70, 'speed': 50}, 'types': ['water', 'grass'], 'weight': 325, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'green', 'shape': 'humanoid', 'habitat': 'waters-edge', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['water1', 'plant'], 'names': {'ja-Hrkt': 'ハスブレロ', 'roomaji': 'Hasubrero', 'ko': '로토스', 'zh-Hant': '蓮帽小童', 'fr': 'Lombre', 'de': 'Lombrero', 'es': 'Lombre', 'it': 'Lombre', 'en': 'Lombre', 'ja': 'ハスブレロ', 'zh-Hans': '莲帽小童'}, 'genera': {'ja-Hrkt': 'ようきポケモン', 'ko': '명랑함포켓몬', 'zh-Hant': '爽朗寶可夢', 'fr': 'Pokémon Jovial', 'de': 'Frohmut', 'es': 'Pokémon Alegre', 'it': 'Pokémon Giocoso', 'en': 'Jolly Pokémon', 'ja': 'ようきポケモン', 'zh-Hans': '爽朗宝可梦'}}
	public class SpecieLombre : PokemonSpecie
	{
#nullable enable
		private static SpecieLombre? _instance = null;
#nullable restore
        public static SpecieLombre Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLombre();
                }
                return _instance;
            }
        }

		public SpecieLombre() : base(
			"Lombre",
			60, // HPs
			50, 50, // Attack & Defense
			60, 70, // Special Attack & Defense
			50			
		) {}
	}


	//Lombre Pokemon Class
	public class Lombre : Pokemon
	{

		public Lombre(string nickname, int level)
		: base(
				271,
				SpecieLombre.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Lombre(int level)
		: base(
				271,
				SpecieLombre.Instance, // Pokemon Specie
				"Lombre", level,
				Water.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Lombre() : base(
			271,
			SpecieLombre.Instance, // Pokemon Specie
			Water.Instance, Grass.Instance			
		) {}
	}
}