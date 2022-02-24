using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Buneary Specie to store common natural stats of every {'abilities': ['run-away', 'klutz', 'limber'], 'base_experience': 70, 'height': 4, 'id': 427, 'moves': ['pound', 'fire-punch', 'ice-punch', 'thunder-punch', 'cut', 'jump-kick', 'headbutt', 'ice-beam', 'low-kick', 'solar-beam', 'thunderbolt', 'thunder-wave', 'dig', 'toxic', 'agility', 'quick-attack', 'double-team', 'defense-curl', 'swift', 'dizzy-punch', 'splash', 'rest', 'substitute', 'snore', 'flail', 'protect', 'sweet-kiss', 'mud-slap', 'foresight', 'endure', 'charm', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'baton-pass', 'encore', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'fake-out', 'uproar', 'facade', 'focus-punch', 'helping-hand', 'magic-coat', 'endeavor', 'secret-power', 'teeter-dance', 'mud-sport', 'hyper-voice', 'fake-tears', 'cosmic-power', 'sky-uppercut', 'bounce', 'covet', 'shock-wave', 'water-pulse', 'healing-wish', 'natural-gift', 'fling', 'copycat', 'last-resort', 'drain-punch', 'switcheroo', 'captivate', 'grass-knot', 'charge-beam', 'double-hit', 'entrainment', 'after-you', 'round', 'circle-throw', 'retaliate', 'work-up', 'confide', 'baby-doll-eyes', 'power-up-punch'], 'name': 'buneary', 'stats': {'hp': 55, 'attack': 66, 'defense': 44, 'special-attack': 44, 'special-defense': 56, 'speed': 85}, 'types': ['normal'], 'weight': 55, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'brown', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['ground', 'humanshape'], 'names': {'ja-Hrkt': 'ミミロル', 'roomaji': 'Mimirol', 'ko': '이어롤', 'zh-Hant': '捲捲耳', 'fr': 'Laporeille', 'de': 'Haspiror', 'es': 'Buneary', 'it': 'Buneary', 'en': 'Buneary', 'ja': 'ミミロル', 'zh-Hans': '卷卷耳'}, 'genera': {'ja-Hrkt': 'うさぎポケモン', 'ko': '토끼포켓몬', 'zh-Hant': '兔子寶可夢', 'fr': 'Pokémon Lapin', 'de': 'Hase', 'es': 'Pokémon Conejo', 'it': 'Pokémon Coniglio', 'en': 'Rabbit Pokémon', 'ja': 'うさぎポケモン', 'zh-Hans': '兔子宝可梦'}}
	public class SpecieBuneary : PokemonSpecie
	{
#nullable enable
		private static SpecieBuneary? _instance = null;
#nullable restore
        public static SpecieBuneary Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBuneary();
                }
                return _instance;
            }
        }

		public SpecieBuneary() : base(
			"Buneary",
			55, // HPs
			66, 44, // Attack & Defense
			44, 56, // Special Attack & Defense
			85			
		) {}
	}


	//Buneary Pokemon Class
	public class Buneary : Pokemon
	{

		public Buneary(string nickname, int level)
		: base(
				427,
				SpecieBuneary.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Buneary(int level)
		: base(
				427,
				SpecieBuneary.Instance, // Pokemon Specie
				"Buneary", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Buneary() : base(
			427,
			SpecieBuneary.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}