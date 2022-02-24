using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Furret Specie to store common natural stats of every {'abilities': ['run-away', 'keen-eye', 'frisk'], 'base_experience': 145, 'height': 18, 'id': 162, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'scratch', 'cut', 'slam', 'headbutt', 'body-slam', 'double-edge', 'flamethrower', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'solar-beam', 'thunderbolt', 'thunder', 'dig', 'toxic', 'agility', 'quick-attack', 'mimic', 'double-team', 'defense-curl', 'swift', 'amnesia', 'fury-swipes', 'rest', 'super-fang', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mud-slap', 'foresight', 'detect', 'endure', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'baton-pass', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'whirlpool', 'uproar', 'facade', 'focus-punch', 'follow-me', 'helping-hand', 'trick', 'brick-break', 'knock-off', 'secret-power', 'hyper-voice', 'covet', 'shock-wave', 'water-pulse', 'natural-gift', 'u-turn', 'fling', 'me-first', 'last-resort', 'sucker-punch', 'aqua-tail', 'focus-blast', 'giga-impact', 'shadow-claw', 'captivate', 'grass-knot', 'charge-beam', 'hone-claws', 'coil', 'round', 'echoed-voice', 'retaliate', 'work-up', 'confide', 'power-up-punch', 'brutal-swing'], 'name': 'furret', 'stats': {'hp': 85, 'attack': 76, 'defense': 64, 'special-attack': 45, 'special-defense': 55, 'speed': 90}, 'types': ['normal'], 'weight': 325, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 90, 'color': 'brown', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'オオタチ', 'roomaji': 'Ootachi', 'ko': '다꼬리', 'zh-Hant': '大尾立', 'fr': 'Fouinar', 'de': 'Wiesenior', 'es': 'Furret', 'it': 'Furret', 'en': 'Furret', 'ja': 'オオタチ', 'zh-Hans': '大尾立'}, 'genera': {'ja-Hrkt': 'どうながポケモン', 'ko': '긴몸통포켓몬', 'zh-Hant': '長軀幹寶可夢', 'fr': 'Pokémon Allongé', 'de': 'Langleib', 'es': 'Pokémon Alargado', 'it': 'Pokémon Lungocorpo', 'en': 'Long Body Pokémon', 'ja': 'どうながポケモン', 'zh-Hans': '长躯干宝可梦'}}
	public class SpecieFurret : PokemonSpecie
	{
#nullable enable
		private static SpecieFurret? _instance = null;
#nullable restore
        public static SpecieFurret Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFurret();
                }
                return _instance;
            }
        }

		public SpecieFurret() : base(
			"Furret",
			85, // HPs
			76, 64, // Attack & Defense
			45, 55, // Special Attack & Defense
			90			
		) {}
	}


	//Furret Pokemon Class
	public class Furret : Pokemon
	{

		public Furret(string nickname, int level)
		: base(
				162,
				SpecieFurret.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Furret(int level)
		: base(
				162,
				SpecieFurret.Instance, // Pokemon Specie
				"Furret", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Furret() : base(
			162,
			SpecieFurret.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}