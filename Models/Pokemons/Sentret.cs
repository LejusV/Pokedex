using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sentret Specie to store common natural stats of every {'abilities': ['run-away', 'keen-eye', 'frisk'], 'base_experience': 43, 'height': 8, 'id': 161, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'scratch', 'cut', 'slam', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'flamethrower', 'surf', 'ice-beam', 'solar-beam', 'thunderbolt', 'dig', 'toxic', 'quick-attack', 'mimic', 'double-team', 'defense-curl', 'focus-energy', 'swift', 'amnesia', 'fury-swipes', 'rest', 'super-fang', 'slash', 'substitute', 'thief', 'snore', 'curse', 'reversal', 'protect', 'mud-slap', 'foresight', 'detect', 'endure', 'charm', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'baton-pass', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'whirlpool', 'uproar', 'facade', 'focus-punch', 'follow-me', 'helping-hand', 'trick', 'assist', 'brick-break', 'knock-off', 'secret-power', 'hyper-voice', 'covet', 'shock-wave', 'water-pulse', 'natural-gift', 'u-turn', 'fling', 'me-first', 'last-resort', 'sucker-punch', 'aqua-tail', 'shadow-claw', 'captivate', 'grass-knot', 'charge-beam', 'hone-claws', 'round', 'echoed-voice', 'retaliate', 'work-up', 'confide', 'baby-doll-eyes', 'power-up-punch', 'brutal-swing'], 'name': 'sentret', 'stats': {'hp': 35, 'attack': 46, 'defense': 34, 'special-attack': 35, 'special-defense': 45, 'speed': 20}, 'types': ['normal'], 'weight': 60, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'オタチ', 'roomaji': 'Otachi', 'ko': '꼬리선', 'zh-Hant': '尾立', 'fr': 'Fouinette', 'de': 'Wiesor', 'es': 'Sentret', 'it': 'Sentret', 'en': 'Sentret', 'ja': 'オタチ', 'zh-Hans': '尾立'}, 'genera': {'ja-Hrkt': 'みはりポケモン', 'ko': '망보기포켓몬', 'zh-Hant': '放哨寶可夢', 'fr': 'Pokémon Espion', 'de': 'Späher', 'es': 'Pokémon Explorador', 'it': 'Pokémon Esplorante', 'en': 'Scout Pokémon', 'ja': 'みはりポケモン', 'zh-Hans': '放哨宝可梦'}}
	public class SpecieSentret : PokemonSpecie
	{
#nullable enable
		private static SpecieSentret? _instance = null;
#nullable restore
        public static SpecieSentret Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSentret();
                }
                return _instance;
            }
        }

		public SpecieSentret() : base(
			"Sentret",
			35, // HPs
			46, 34, // Attack & Defense
			35, 45, // Special Attack & Defense
			20			
		) {}
	}


	//Sentret Pokemon Class
	public class Sentret : Pokemon
	{

		public Sentret(string nickname, int level)
		: base(
				161,
				SpecieSentret.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sentret(int level)
		: base(
				161,
				SpecieSentret.Instance, // Pokemon Specie
				"Sentret", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sentret() : base(
			161,
			SpecieSentret.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}