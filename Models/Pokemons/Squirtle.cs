using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Squirtle Specie to store common natural stats of every {'abilities': ['torrent', 'rain-dish'], 'base_experience': 63, 'height': 5, 'id': 7, 'moves': ['mega-punch', 'ice-punch', 'mega-kick', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'bite', 'mist', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'dig', 'toxic', 'confusion', 'rage', 'mimic', 'double-team', 'withdraw', 'defense-curl', 'haze', 'reflect', 'bide', 'waterfall', 'skull-bash', 'bubble', 'rest', 'substitute', 'snore', 'curse', 'flail', 'protect', 'mud-slap', 'foresight', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'rapid-spin', 'iron-tail', 'hidden-power', 'rain-dance', 'mirror-coat', 'rock-smash', 'whirlpool', 'fake-out', 'hail', 'facade', 'focus-punch', 'brick-break', 'yawn', 'refresh', 'secret-power', 'dive', 'mud-sport', 'rock-tomb', 'water-spout', 'muddy-water', 'iron-defense', 'water-pulse', 'gyro-ball', 'brine', 'natural-gift', 'fling', 'aqua-ring', 'aura-sphere', 'aqua-tail', 'dragon-pulse', 'zen-headbutt', 'captivate', 'aqua-jet', 'round', 'scald', 'water-pledge', 'work-up', 'confide', 'power-up-punch'], 'name': 'squirtle', 'stats': {'hp': 44, 'attack': 48, 'defense': 65, 'special-attack': 50, 'special-defense': 64, 'speed': 43}, 'types': ['water'], 'weight': 90, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': 'waters-edge', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'water1'], 'names': {'ja-Hrkt': 'ゼニガメ', 'roomaji': 'Zenigame', 'ko': '꼬부기', 'zh-Hant': '傑尼龜', 'fr': 'Carapuce', 'de': 'Schiggy', 'es': 'Squirtle', 'it': 'Squirtle', 'en': 'Squirtle', 'ja': 'ゼニガメ', 'zh-Hans': '杰尼龟'}, 'genera': {'ja-Hrkt': 'かめのこポケモン', 'ko': '꼬마거북포켓몬', 'zh-Hant': '小龜寶可夢', 'fr': 'Pokémon Minitortue', 'de': 'Minikröte', 'es': 'Pokémon Tortuguita', 'it': 'Pokémon Tartaghina', 'en': 'Tiny Turtle Pokémon', 'ja': 'かめのこポケモン', 'zh-Hans': '小龟宝可梦'}}
	public class SpecieSquirtle : PokemonSpecie
	{
#nullable enable
		private static SpecieSquirtle? _instance = null;
#nullable restore
        public static SpecieSquirtle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSquirtle();
                }
                return _instance;
            }
        }

		public SpecieSquirtle() : base(
			"Squirtle",
			44, // HPs
			48, 65, // Attack & Defense
			50, 64, // Special Attack & Defense
			43			
		) {}
	}


	//Squirtle Pokemon Class
	public class Squirtle : Pokemon
	{

		public Squirtle(string nickname, int level)
		: base(
				7,
				SpecieSquirtle.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Squirtle(int level)
		: base(
				7,
				SpecieSquirtle.Instance, // Pokemon Specie
				"Squirtle", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Squirtle() : base(
			7,
			SpecieSquirtle.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}