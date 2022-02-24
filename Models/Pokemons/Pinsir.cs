using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pinsir Specie to store common natural stats of every {'abilities': ['hyper-cutter', 'mold-breaker', 'moxie'], 'base_experience': 175, 'height': 15, 'id': 127, 'moves': ['vice-grip', 'guillotine', 'swords-dance', 'cut', 'bind', 'headbutt', 'fury-attack', 'body-slam', 'take-down', 'thrash', 'double-edge', 'hyper-beam', 'submission', 'seismic-toss', 'strength', 'string-shot', 'earthquake', 'dig', 'toxic', 'quick-attack', 'rage', 'mimic', 'double-team', 'harden', 'focus-energy', 'bide', 'rest', 'rock-slide', 'slash', 'substitute', 'thief', 'snore', 'curse', 'flail', 'protect', 'feint-attack', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'vital-throw', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'focus-punch', 'superpower', 'revenge', 'brick-break', 'knock-off', 'secret-power', 'rock-tomb', 'iron-defense', 'bulk-up', 'natural-gift', 'feint', 'close-combat', 'fling', 'me-first', 'x-scissor', 'focus-blast', 'giga-impact', 'rock-climb', 'stone-edge', 'captivate', 'stealth-rock', 'bug-bite', 'double-hit', 'smack-down', 'storm-throw', 'round', 'struggle-bug', 'bulldoze', 'confide', 'brutal-swing'], 'name': 'pinsir', 'stats': {'hp': 65, 'attack': 125, 'defense': 100, 'special-attack': 55, 'special-defense': 70, 'speed': 85}, 'types': ['bug'], 'weight': 550, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 45, 'color': 'brown', 'shape': 'humanoid', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'カイロス', 'roomaji': 'Kailios', 'ko': '쁘사이저', 'zh-Hant': '凱羅斯', 'fr': 'Scarabrute', 'de': 'Pinsir', 'es': 'Pinsir', 'it': 'Pinsir', 'en': 'Pinsir', 'ja': 'カイロス', 'zh-Hans': '凯罗斯'}, 'genera': {'ja-Hrkt': 'くわがたポケモン', 'ko': '뿔집게포켓몬', 'zh-Hant': '鍬形蟲寶可夢', 'fr': 'Pokémon Scarabée', 'de': 'Kneifkäfer', 'es': 'Pokémon Escarabajo', 'it': 'Pokémon Cervolante', 'en': 'Stag Beetle Pokémon', 'ja': 'くわがたポケモン', 'zh-Hans': '锹形虫宝可梦'}}
	public class SpeciePinsir : PokemonSpecie
	{
#nullable enable
		private static SpeciePinsir? _instance = null;
#nullable restore
        public static SpeciePinsir Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePinsir();
                }
                return _instance;
            }
        }

		public SpeciePinsir() : base(
			"Pinsir",
			65, // HPs
			125, 100, // Attack & Defense
			55, 70, // Special Attack & Defense
			85			
		) {}
	}


	//Pinsir Pokemon Class
	public class Pinsir : Pokemon
	{

		public Pinsir(string nickname, int level)
		: base(
				127,
				SpeciePinsir.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Pinsir() : base(
			127,
			SpeciePinsir.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
	}
}