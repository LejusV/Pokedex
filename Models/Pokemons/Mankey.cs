using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mankey Specie to store common natural stats of every {'abilities': ['vital-spirit', 'anger-point', 'defiant'], 'base_experience': 61, 'height': 5, 'id': 56, 'moves': ['karate-chop', 'mega-punch', 'pay-day', 'fire-punch', 'ice-punch', 'thunder-punch', 'scratch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'thrash', 'double-edge', 'leer', 'submission', 'low-kick', 'counter', 'seismic-toss', 'strength', 'thunderbolt', 'thunder', 'earthquake', 'dig', 'toxic', 'meditate', 'rage', 'mimic', 'screech', 'double-team', 'defense-curl', 'focus-energy', 'bide', 'metronome', 'swift', 'skull-bash', 'fury-swipes', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'reversal', 'spite', 'protect', 'mud-slap', 'foresight', 'detect', 'outrage', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'encore', 'pursuit', 'iron-tail', 'hidden-power', 'cross-chop', 'rain-dance', 'sunny-day', 'psych-up', 'rock-smash', 'beat-up', 'uproar', 'facade', 'focus-punch', 'smelling-salts', 'taunt', 'helping-hand', 'role-play', 'revenge', 'brick-break', 'endeavor', 'secret-power', 'overheat', 'rock-tomb', 'aerial-ace', 'bulk-up', 'covet', 'natural-gift', 'u-turn', 'close-combat', 'payback', 'assurance', 'fling', 'punishment', 'poison-jab', 'night-slash', 'seed-bomb', 'vacuum-wave', 'focus-blast', 'rock-climb', 'gunk-shot', 'captivate', 'hone-claws', 'smack-down', 'low-sweep', 'round', 'acrobatics', 'retaliate', 'final-gambit', 'bulldoze', 'work-up', 'dual-chop', 'confide', 'power-up-punch', 'power-trip', 'stomping-tantrum'], 'name': 'mankey', 'stats': {'hp': 40, 'attack': 80, 'defense': 35, 'special-attack': 35, 'special-defense': 45, 'speed': 70}, 'types': ['fighting'], 'weight': 280, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'brown', 'shape': 'upright', 'habitat': 'mountain', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'マンキー', 'roomaji': 'Mankey', 'ko': '망키', 'zh-Hant': '猴怪', 'fr': 'Férosinge', 'de': 'Menki', 'es': 'Mankey', 'it': 'Mankey', 'en': 'Mankey', 'ja': 'マンキー', 'zh-Hans': '猴怪'}, 'genera': {'ja-Hrkt': 'ぶたざるポケモン', 'ko': '돈숭이포켓몬', 'zh-Hant': '豬猴寶可夢', 'fr': 'Pokémon Porsinge', 'de': 'Schwein/Affe', 'es': 'Pokémon Mono Cerdo', 'it': 'Pokémon Suinpanzé', 'en': 'Pig Monkey Pokémon', 'ja': 'ぶたざるポケモン', 'zh-Hans': '猪猴宝可梦'}}
	public class SpecieMankey : PokemonSpecie
	{
#nullable enable
		private static SpecieMankey? _instance = null;
#nullable restore
        public static SpecieMankey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMankey();
                }
                return _instance;
            }
        }

		public SpecieMankey() : base(
			"Mankey",
			40, // HPs
			80, 35, // Attack & Defense
			35, 45, // Special Attack & Defense
			70			
		) {}
	}


	//Mankey Pokemon Class
	public class Mankey : Pokemon
	{

		public Mankey(string nickname, int level)
		: base(
				56,
				SpecieMankey.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Mankey() : base(
			56,
			SpecieMankey.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}