using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Ledian Specie to store common natural stats of every {'abilities': ['swarm', 'early-bird', 'iron-fist'], 'base_experience': 137, 'height': 14, 'id': 166, 'moves': ['comet-punch', 'mega-punch', 'ice-punch', 'thunder-punch', 'swords-dance', 'headbutt', 'tackle', 'double-edge', 'supersonic', 'hyper-beam', 'strength', 'solar-beam', 'string-shot', 'dig', 'toxic', 'agility', 'mimic', 'double-team', 'light-screen', 'reflect', 'swift', 'flash', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mach-punch', 'giga-drain', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'baton-pass', 'sweet-scent', 'hidden-power', 'sunny-day', 'rock-smash', 'uproar', 'facade', 'focus-punch', 'brick-break', 'knock-off', 'secret-power', 'air-cutter', 'silver-wind', 'aerial-ace', 'roost', 'natural-gift', 'tailwind', 'u-turn', 'fling', 'air-slash', 'bug-buzz', 'drain-punch', 'focus-blast', 'giga-impact', 'captivate', 'bug-bite', 'ominous-wind', 'round', 'acrobatics', 'struggle-bug', 'confide', 'infestation', 'power-up-punch'], 'name': 'ledian', 'stats': {'hp': 55, 'attack': 35, 'defense': 50, 'special-attack': 55, 'special-defense': 110, 'speed': 85}, 'types': ['bug', 'flying'], 'weight': 356, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 90, 'color': 'red', 'shape': 'wings', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'fast', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'レディアン', 'roomaji': 'Redian', 'ko': '레디안', 'zh-Hant': '安瓢蟲', 'fr': 'Coxyclaque', 'de': 'Ledian', 'es': 'Ledian', 'it': 'Ledian', 'en': 'Ledian', 'ja': 'レディアン', 'zh-Hans': '安瓢虫'}, 'genera': {'ja-Hrkt': 'いつつぼしポケモン', 'ko': '별다섯포켓몬', 'zh-Hant': '五星寶可夢', 'fr': 'Pokémon 5 Étoiles', 'de': 'Fünf-Punkt', 'es': 'Pokémon 5 Estrellas', 'it': 'Pokémon Pentastra', 'en': 'Five Star Pokémon', 'ja': 'いつつぼしポケモン', 'zh-Hans': '五星宝可梦'}}
	public class SpecieLedian : PokemonSpecie
	{
#nullable enable
		private static SpecieLedian? _instance = null;
#nullable restore
        public static SpecieLedian Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLedian();
                }
                return _instance;
            }
        }

		public SpecieLedian() : base(
			"Ledian",
			55, // HPs
			35, 50, // Attack & Defense
			55, 110, // Special Attack & Defense
			85			
		) {}
	}


	//Ledian Pokemon Class
	public class Ledian : Pokemon
	{

		public Ledian(string nickname, int level)
		: base(
				166,
				SpecieLedian.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ledian() : base(
			166,
			SpecieLedian.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
	}
}