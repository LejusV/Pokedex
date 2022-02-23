using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Ledyba Specie to store common natural stats of every {'abilities': ['swarm', 'early-bird', 'rattled'], 'base_experience': 53, 'height': 10, 'id': 165, 'moves': ['comet-punch', 'mega-punch', 'ice-punch', 'thunder-punch', 'swords-dance', 'headbutt', 'tackle', 'double-edge', 'supersonic', 'psybeam', 'counter', 'solar-beam', 'string-shot', 'dig', 'toxic', 'agility', 'mimic', 'screech', 'double-team', 'light-screen', 'reflect', 'bide', 'swift', 'dizzy-punch', 'flash', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mach-punch', 'giga-drain', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'baton-pass', 'encore', 'sweet-scent', 'hidden-power', 'sunny-day', 'uproar', 'facade', 'focus-punch', 'brick-break', 'knock-off', 'secret-power', 'air-cutter', 'silver-wind', 'aerial-ace', 'roost', 'natural-gift', 'tailwind', 'u-turn', 'fling', 'air-slash', 'bug-buzz', 'drain-punch', 'captivate', 'bug-bite', 'ominous-wind', 'round', 'acrobatics', 'struggle-bug', 'confide', 'infestation', 'power-up-punch'], 'name': 'ledyba', 'stats': {'hp': 40, 'attack': 20, 'defense': 30, 'special-attack': 40, 'special-defense': 80, 'speed': 55}, 'types': ['bug', 'flying'], 'weight': 108, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'red', 'shape': 'wings', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'fast', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'レディバ', 'roomaji': 'Rediba', 'ko': '레디바', 'zh-Hant': '芭瓢蟲', 'fr': 'Coxy', 'de': 'Ledyba', 'es': 'Ledyba', 'it': 'Ledyba', 'en': 'Ledyba', 'ja': 'レディバ', 'zh-Hans': '芭瓢虫'}, 'genera': {'ja-Hrkt': 'いつつぼしポケモン', 'ko': '별다섯포켓몬', 'zh-Hant': '五星寶可夢', 'fr': 'Pokémon 5 Étoiles', 'de': 'Fünf-Punkt', 'es': 'Pokémon 5 Estrellas', 'it': 'Pokémon Pentastra', 'en': 'Five Star Pokémon', 'ja': 'いつつぼしポケモン', 'zh-Hans': '五星宝可梦'}}
	public class SpecieLedyba : PokemonSpecie
	{
#nullable enable
		private static SpecieLedyba? _instance = null;
#nullable restore
        public static SpecieLedyba Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLedyba();
                }
                return _instance;
            }
        }

		public SpecieLedyba() : base(
			"Ledyba",
			40, // HPs
			20, 30, // Attack & Defense
			40, 80, // Special Attack & Defense
			55			
		) {}
	}


	//Ledyba Pokemon Class
	public class Ledyba : Pokemon
	{

		public Ledyba(string nickname, int level) : base(
			165,
			SpecieLedyba.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance, Flying.Instance			
		) {}

		public Ledyba() : base(
			165,
			SpecieLedyba.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
	}
}