using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Wartortle Specie to store common natural stats of every {'abilities': ['torrent', 'rain-dish'], 'base_experience': 142, 'height': 10, 'id': 8, 'moves': ['mega-punch', 'ice-punch', 'mega-kick', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'bite', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'withdraw', 'defense-curl', 'reflect', 'bide', 'waterfall', 'skull-bash', 'bubble', 'rest', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'rapid-spin', 'iron-tail', 'hidden-power', 'rain-dance', 'rock-smash', 'whirlpool', 'hail', 'facade', 'focus-punch', 'brick-break', 'secret-power', 'dive', 'rock-tomb', 'iron-defense', 'water-pulse', 'gyro-ball', 'brine', 'natural-gift', 'fling', 'aqua-tail', 'dragon-pulse', 'zen-headbutt', 'captivate', 'round', 'scald', 'water-pledge', 'work-up', 'confide', 'power-up-punch'], 'name': 'wartortle', 'stats': {'hp': 59, 'attack': 63, 'defense': 80, 'special-attack': 65, 'special-defense': 80, 'speed': 58}, 'types': ['water'], 'weight': 225, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': 'waters-edge', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'water1'], 'names': {'ja-Hrkt': 'カメール', 'roomaji': 'Kameil', 'ko': '어니부기', 'zh-Hant': '卡咪龜', 'fr': 'Carabaffe', 'de': 'Schillok', 'es': 'Wartortle', 'it': 'Wartortle', 'en': 'Wartortle', 'ja': 'カメール', 'zh-Hans': '卡咪龟'}, 'genera': {'ja-Hrkt': 'かめポケモン', 'ko': '거북포켓몬', 'zh-Hant': '龜寶可夢', 'fr': 'Pokémon Tortue', 'de': 'Kröte', 'es': 'Pokémon Tortuga', 'it': 'Pokémon Tartaruga', 'en': 'Turtle Pokémon', 'ja': 'かめポケモン', 'zh-Hans': '龟宝可梦'}}
	public class SpecieWartortle : PokemonSpecie
	{
#nullable enable
		private static SpecieWartortle? _instance = null;
#nullable restore
        public static SpecieWartortle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWartortle();
                }
                return _instance;
            }
        }

		public SpecieWartortle() : base(
			"Wartortle",
			59, // HPs
			63, 80, // Attack & Defense
			65, 80, // Special Attack & Defense
			58			
		) {}
	}


	//Wartortle Pokemon Class
	public class Wartortle : Pokemon
	{

		public Wartortle(string nickname, int level)
		: base(
				8,
				SpecieWartortle.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Wartortle(int level)
		: base(
				8,
				SpecieWartortle.Instance, // Pokemon Specie
				"Wartortle", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Wartortle() : base(
			8,
			SpecieWartortle.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}