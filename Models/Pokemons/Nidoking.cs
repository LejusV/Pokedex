using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Nidoking Specie to store common natural stats of every {'abilities': ['poison-point', 'rivalry', 'sheer-force'], 'base_experience': 227, 'height': 14, 'id': 34, 'moves': ['mega-punch', 'pay-day', 'fire-punch', 'ice-punch', 'thunder-punch', 'cut', 'double-kick', 'mega-kick', 'headbutt', 'horn-attack', 'horn-drill', 'tackle', 'body-slam', 'take-down', 'thrash', 'double-edge', 'poison-sting', 'roar', 'flamethrower', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'peck', 'submission', 'counter', 'seismic-toss', 'strength', 'thunderbolt', 'thunder', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'defense-curl', 'reflect', 'focus-energy', 'bide', 'fire-blast', 'skull-bash', 'rest', 'rock-slide', 'super-fang', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'mud-slap', 'icy-wind', 'detect', 'outrage', 'sandstorm', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'megahorn', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'whirlpool', 'uproar', 'torment', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'superpower', 'brick-break', 'secret-power', 'rock-tomb', 'shock-wave', 'water-pulse', 'natural-gift', 'fling', 'sucker-punch', 'poison-jab', 'aqua-tail', 'dragon-pulse', 'focus-blast', 'earth-power', 'giga-impact', 'avalanche', 'shadow-claw', 'rock-climb', 'stone-edge', 'captivate', 'stealth-rock', 'hone-claws', 'venoshock', 'smack-down', 'sludge-wave', 'round', 'echoed-voice', 'chip-away', 'incinerate', 'quash', 'bulldoze', 'dragon-tail', 'drill-run', 'confide', 'power-up-punch', 'smart-strike'], 'name': 'nidoking', 'stats': {'hp': 81, 'attack': 102, 'defense': 77, 'special-attack': 85, 'special-defense': 75, 'speed': 85}, 'types': ['poison', 'ground'], 'weight': 620, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 0, 'capture_rate': 45, 'color': 'purple', 'shape': 'upright', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'ground'], 'names': {'ja-Hrkt': 'ニドキング', 'roomaji': 'Nidoking', 'ko': '니드킹', 'zh-Hant': '尼多王', 'fr': 'Nidoking', 'de': 'Nidoking', 'es': 'Nidoking', 'it': 'Nidoking', 'en': 'Nidoking', 'ja': 'ニドキング', 'zh-Hans': '尼多王'}, 'genera': {'ja-Hrkt': 'ドリルポケモン', 'ko': '드릴포켓몬', 'zh-Hant': '鑽錐寶可夢', 'fr': 'Pokémon Perceur', 'de': 'Bohrer', 'es': 'Pokémon Taladro', 'it': 'Pokémon Trapano', 'en': 'Drill Pokémon', 'ja': 'ドリルポケモン', 'zh-Hans': '钻锥宝可梦'}}
	public class SpecieNidoking : PokemonSpecie
	{
#nullable enable
		private static SpecieNidoking? _instance = null;
#nullable restore
        public static SpecieNidoking Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNidoking();
                }
                return _instance;
            }
        }

		public SpecieNidoking() : base(
			"Nidoking",
			81, // HPs
			102, 77, // Attack & Defense
			85, 75, // Special Attack & Defense
			85			
		) {}
	}


	//Nidoking Pokemon Class
	public class Nidoking : Pokemon
	{

		public Nidoking(string nickname, int level)
		: base(
				34,
				SpecieNidoking.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Nidoking(int level)
		: base(
				34,
				SpecieNidoking.Instance, // Pokemon Specie
				"Nidoking", level,
				Poison.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Nidoking() : base(
			34,
			SpecieNidoking.Instance, // Pokemon Specie
			Poison.Instance, Ground.Instance			
		) {}
	}
}