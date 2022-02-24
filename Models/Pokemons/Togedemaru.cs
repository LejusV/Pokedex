using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Togedemaru Specie to store common natural stats of every {'abilities': ['iron-barbs', 'lightning-rod', 'sturdy'], 'base_experience': 152, 'height': 3, 'id': 777, 'moves': ['tackle', 'twineedle', 'pin-missile', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'double-team', 'defense-curl', 'reflect', 'rest', 'substitute', 'thief', 'flail', 'reversal', 'protect', 'rollout', 'swagger', 'spark', 'attract', 'sleep-talk', 'return', 'present', 'frustration', 'encore', 'hidden-power', 'fake-out', 'facade', 'charge', 'wish', 'tickle', 'gyro-ball', 'u-turn', 'payback', 'fling', 'magnet-rise', 'poison-jab', 'giga-impact', 'discharge', 'grass-knot', 'charge-beam', 'round', 'volt-switch', 'work-up', 'wild-charge', 'fell-stinger', 'disarming-voice', 'confide', 'spiky-shield', 'electric-terrain', 'nuzzle', 'zing-zap'], 'name': 'togedemaru', 'stats': {'hp': 65, 'attack': 98, 'defense': 63, 'special-attack': 40, 'special-defense': 73, 'speed': 96}, 'types': ['electric', 'steel'], 'weight': 33, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 4, 'capture_rate': 180, 'color': 'gray', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['ground', 'fairy'], 'names': {'ja-Hrkt': 'トゲデマル', 'ko': '토게데마루', 'zh-Hant': '托戈德瑪爾', 'fr': 'Togedemaru', 'de': 'Togedemaru', 'es': 'Togedemaru', 'it': 'Togedemaru', 'en': 'Togedemaru', 'ja': 'トゲデマル', 'zh-Hans': '托戈德玛尔'}, 'genera': {'ja-Hrkt': 'まるまりポケモン', 'ko': '동글동글포켓몬', 'zh-Hant': '蜷縮寶可夢', 'fr': 'Pokémon Roulenboule', 'de': 'Einigler', 'es': 'Pokémon Bolita', 'it': 'Pokémon Ricciopalla', 'en': 'Roly-Poly Pokémon', 'ja': 'まるまりポケモン', 'zh-Hans': '蜷缩宝可梦'}}
	public class SpecieTogedemaru : PokemonSpecie
	{
#nullable enable
		private static SpecieTogedemaru? _instance = null;
#nullable restore
        public static SpecieTogedemaru Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTogedemaru();
                }
                return _instance;
            }
        }

		public SpecieTogedemaru() : base(
			"Togedemaru",
			65, // HPs
			98, 63, // Attack & Defense
			40, 73, // Special Attack & Defense
			96			
		) {}
	}


	//Togedemaru Pokemon Class
	public class Togedemaru : Pokemon
	{

		public Togedemaru(string nickname, int level)
		: base(
				777,
				SpecieTogedemaru.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Togedemaru() : base(
			777,
			SpecieTogedemaru.Instance, // Pokemon Specie
			Electric.Instance, Steel.Instance			
		) {}
	}
}