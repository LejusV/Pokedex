using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Ariados Specie to store common natural stats of every {'abilities': ['swarm', 'insomnia', 'sniper'], 'base_experience': 140, 'height': 11, 'id': 168, 'moves': ['swords-dance', 'body-slam', 'double-edge', 'poison-sting', 'pin-missile', 'hyper-beam', 'absorb', 'solar-beam', 'string-shot', 'dig', 'toxic', 'psychic', 'agility', 'night-shade', 'mimic', 'screech', 'double-team', 'focus-energy', 'constrict', 'leech-life', 'flash', 'fury-swipes', 'rest', 'substitute', 'thief', 'spider-web', 'snore', 'curse', 'protect', 'scary-face', 'sludge-bomb', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'sunny-day', 'facade', 'secret-power', 'signal-beam', 'bounce', 'natural-gift', 'sucker-punch', 'poison-jab', 'x-scissor', 'giga-impact', 'shadow-sneak', 'cross-poison', 'captivate', 'bug-bite', 'hone-claws', 'venoshock', 'foul-play', 'round', 'struggle-bug', 'electroweb', 'sticky-web', 'fell-stinger', 'confide', 'venom-drench', 'infestation', 'toxic-thread', 'smart-strike'], 'name': 'ariados', 'stats': {'hp': 70, 'attack': 90, 'defense': 70, 'special-attack': 60, 'special-defense': 70, 'speed': 40}, 'types': ['bug', 'poison'], 'weight': 335, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 90, 'color': 'red', 'shape': 'armor', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'fast', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'アリアドス', 'roomaji': 'Ariados', 'ko': '아리아도스', 'zh-Hant': '阿利多斯', 'fr': 'Migalos', 'de': 'Ariados', 'es': 'Ariados', 'it': 'Ariados', 'en': 'Ariados', 'ja': 'アリアドス', 'zh-Hans': '阿利多斯'}, 'genera': {'ja-Hrkt': 'あしながポケモン', 'ko': '롱다리포켓몬', 'zh-Hant': '長腿寶可夢', 'fr': 'Pokémon Long-Patte', 'de': 'Langbein', 'es': 'Pokémon Pata Larga', 'it': 'Pokémon Lungazampa', 'en': 'Long Leg Pokémon', 'ja': 'あしながポケモン', 'zh-Hans': '长腿宝可梦'}}
	public class SpecieAriados : PokemonSpecie
	{
#nullable enable
		private static SpecieAriados? _instance = null;
#nullable restore
        public static SpecieAriados Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAriados();
                }
                return _instance;
            }
        }

		public SpecieAriados() : base(
			"Ariados",
			70, // HPs
			90, 70, // Attack & Defense
			60, 70, // Special Attack & Defense
			40			
		) {}
	}


	//Ariados Pokemon Class
	public class Ariados : Pokemon
	{

		public Ariados(string nickname, int level)
		: base(
				168,
				SpecieAriados.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ariados() : base(
			168,
			SpecieAriados.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
	}
}