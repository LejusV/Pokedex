using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sandslash Specie to store common natural stats of every {'abilities': ['sand-veil', 'sand-rush'], 'base_experience': 158, 'height': 10, 'id': 28, 'moves': ['scratch', 'swords-dance', 'cut', 'sand-attack', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'poison-sting', 'hyper-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'defense-curl', 'bide', 'swift', 'skull-bash', 'fury-swipes', 'rest', 'rock-slide', 'super-fang', 'slash', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mud-slap', 'detect', 'sandstorm', 'endure', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'magnitude', 'dynamic-punch', 'rapid-spin', 'iron-tail', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'focus-punch', 'brick-break', 'knock-off', 'secret-power', 'crush-claw', 'rock-tomb', 'sand-tomb', 'aerial-ace', 'covet', 'gyro-ball', 'natural-gift', 'fling', 'poison-jab', 'x-scissor', 'focus-blast', 'earth-power', 'giga-impact', 'shadow-claw', 'rock-climb', 'stone-edge', 'captivate', 'stealth-rock', 'hone-claws', 'round', 'bulldoze', 'confide'], 'name': 'sandslash', 'stats': {'hp': 75, 'attack': 100, 'defense': 110, 'special-attack': 45, 'special-defense': 55, 'speed': 65}, 'types': ['ground'], 'weight': 295, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'yellow', 'shape': 'upright', 'habitat': 'rough-terrain', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'サンドパン', 'roomaji': 'Sandpan', 'ko': '고지', 'zh-Hant': '穿山王', 'fr': 'Sablaireau', 'de': 'Sandamer', 'es': 'Sandslash', 'it': 'Sandslash', 'en': 'Sandslash', 'ja': 'サンドパン', 'zh-Hans': '穿山王'}, 'genera': {'ja-Hrkt': 'ねずみポケモン', 'ko': '쥐포켓몬', 'zh-Hant': '鼠寶可夢', 'fr': 'Pokémon Souris', 'de': 'Maus', 'es': 'Pokémon Ratón', 'it': 'Pokémon Topo', 'en': 'Mouse Pokémon', 'ja': 'ねずみポケモン', 'zh-Hans': '鼠宝可梦'}}
	public class SpecieSandslash : PokemonSpecie
	{
#nullable enable
		private static SpecieSandslash? _instance = null;
#nullable restore
        public static SpecieSandslash Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSandslash();
                }
                return _instance;
            }
        }

		public SpecieSandslash() : base(
			"Sandslash",
			75, // HPs
			100, 110, // Attack & Defense
			45, 55, // Special Attack & Defense
			65			
		) {}
	}


	//Sandslash Pokemon Class
	public class Sandslash : Pokemon
	{

		public Sandslash(string nickname, int level)
		: base(
				28,
				SpecieSandslash.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sandslash(int level)
		: base(
				28,
				SpecieSandslash.Instance, // Pokemon Specie
				"Sandslash", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sandslash() : base(
			28,
			SpecieSandslash.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
	}
}