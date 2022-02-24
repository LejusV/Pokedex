using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Primeape Specie to store common natural stats of every {'abilities': ['vital-spirit', 'anger-point', 'defiant'], 'base_experience': 159, 'height': 10, 'id': 57, 'moves': ['karate-chop', 'mega-punch', 'pay-day', 'fire-punch', 'ice-punch', 'thunder-punch', 'scratch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'thrash', 'double-edge', 'leer', 'hyper-beam', 'submission', 'low-kick', 'counter', 'seismic-toss', 'strength', 'thunderbolt', 'thunder', 'earthquake', 'dig', 'toxic', 'rage', 'mimic', 'screech', 'double-team', 'defense-curl', 'focus-energy', 'bide', 'metronome', 'swift', 'skull-bash', 'fury-swipes', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'spite', 'protect', 'mud-slap', 'detect', 'outrage', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'pursuit', 'iron-tail', 'hidden-power', 'cross-chop', 'rain-dance', 'sunny-day', 'psych-up', 'rock-smash', 'uproar', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'role-play', 'brick-break', 'endeavor', 'secret-power', 'overheat', 'rock-tomb', 'aerial-ace', 'bulk-up', 'covet', 'natural-gift', 'u-turn', 'close-combat', 'payback', 'assurance', 'fling', 'punishment', 'poison-jab', 'seed-bomb', 'vacuum-wave', 'focus-blast', 'giga-impact', 'rock-climb', 'gunk-shot', 'stone-edge', 'captivate', 'hone-claws', 'smack-down', 'low-sweep', 'round', 'acrobatics', 'retaliate', 'final-gambit', 'bulldoze', 'work-up', 'dual-chop', 'confide', 'power-up-punch', 'stomping-tantrum'], 'name': 'primeape', 'stats': {'hp': 65, 'attack': 105, 'defense': 60, 'special-attack': 60, 'special-defense': 70, 'speed': 95}, 'types': ['fighting'], 'weight': 320, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'brown', 'shape': 'upright', 'habitat': 'mountain', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'オコリザル', 'roomaji': 'Okorizaru', 'ko': '성원숭', 'zh-Hant': '火爆猴', 'fr': 'Colossinge', 'de': 'Rasaff', 'es': 'Primeape', 'it': 'Primeape', 'en': 'Primeape', 'ja': 'オコリザル', 'zh-Hans': '火暴猴'}, 'genera': {'ja-Hrkt': 'ぶたざるポケモン', 'ko': '돈숭이포켓몬', 'zh-Hant': '豬猴寶可夢', 'fr': 'Pokémon Porsinge', 'de': 'Schwein/Affe', 'es': 'Pokémon Mono Cerdo', 'it': 'Pokémon Suinpanzé', 'en': 'Pig Monkey Pokémon', 'ja': 'ぶたざるポケモン', 'zh-Hans': '猪猴宝可梦'}}
	public class SpeciePrimeape : PokemonSpecie
	{
#nullable enable
		private static SpeciePrimeape? _instance = null;
#nullable restore
        public static SpeciePrimeape Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePrimeape();
                }
                return _instance;
            }
        }

		public SpeciePrimeape() : base(
			"Primeape",
			65, // HPs
			105, 60, // Attack & Defense
			60, 70, // Special Attack & Defense
			95			
		) {}
	}


	//Primeape Pokemon Class
	public class Primeape : Pokemon
	{

		public Primeape(string nickname, int level)
		: base(
				57,
				SpeciePrimeape.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Primeape(int level)
		: base(
				57,
				SpeciePrimeape.Instance, // Pokemon Specie
				"Primeape", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Primeape() : base(
			57,
			SpeciePrimeape.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}