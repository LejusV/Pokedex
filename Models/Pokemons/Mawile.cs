using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mawile Specie to store common natural stats of every {'abilities': ['hyper-cutter', 'intimidate', 'sheer-force'], 'base_experience': 133, 'height': 6, 'id': 303, 'moves': ['mega-punch', 'ice-punch', 'thunder-punch', 'vice-grip', 'swords-dance', 'slam', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'bite', 'growl', 'flamethrower', 'ice-beam', 'hyper-beam', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'toxic', 'mimic', 'double-team', 'fire-blast', 'rest', 'rock-slide', 'super-fang', 'substitute', 'snore', 'protect', 'feint-attack', 'sludge-bomb', 'mud-slap', 'icy-wind', 'sandstorm', 'endure', 'false-swipe', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'dynamic-punch', 'baton-pass', 'sweet-scent', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'psych-up', 'ancient-power', 'shadow-ball', 'rock-smash', 'stockpile', 'spit-up', 'swallow', 'torment', 'facade', 'focus-punch', 'taunt', 'brick-break', 'knock-off', 'snatch', 'secret-power', 'poison-fang', 'astonish', 'fake-tears', 'rock-tomb', 'tickle', 'iron-defense', 'natural-gift', 'metal-burst', 'payback', 'embargo', 'fling', 'guard-swap', 'punishment', 'last-resort', 'sucker-punch', 'magnet-rise', 'dark-pulse', 'focus-blast', 'giga-impact', 'thunder-fang', 'ice-fang', 'fire-fang', 'flash-cannon', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'grass-knot', 'charge-beam', 'foul-play', 'round', 'incinerate', 'misty-terrain', 'play-rough', 'fairy-wind', 'confide', 'power-up-punch'], 'name': 'mawile', 'stats': {'hp': 50, 'attack': 85, 'defense': 85, 'special-attack': 55, 'special-defense': 55, 'speed': 50}, 'types': ['steel', 'fairy'], 'weight': 115, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'black', 'shape': 'humanoid', 'habitat': 'cave', 'generation': 'generation-iii', 'growth_rate': 'fast', 'egg_groups': ['ground', 'fairy'], 'names': {'ja-Hrkt': 'クチート', 'roomaji': 'Kucheat', 'ko': '입치트', 'zh-Hant': '大嘴娃', 'fr': 'Mysdibule', 'de': 'Flunkifer', 'es': 'Mawile', 'it': 'Mawile', 'en': 'Mawile', 'ja': 'クチート', 'zh-Hans': '大嘴娃'}, 'genera': {'ja-Hrkt': 'あざむきポケモン', 'ko': '배반포켓몬', 'zh-Hant': '欺騙寶可夢', 'fr': 'Pokémon Trompeur', 'de': 'Schwindler', 'es': 'Pokémon Tramposo', 'it': 'Pokémon Inganno', 'en': 'Deceiver Pokémon', 'ja': 'あざむきポケモン', 'zh-Hans': '欺骗宝可梦'}}
	public class SpecieMawile : PokemonSpecie
	{
#nullable enable
		private static SpecieMawile? _instance = null;
#nullable restore
        public static SpecieMawile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMawile();
                }
                return _instance;
            }
        }

		public SpecieMawile() : base(
			"Mawile",
			50, // HPs
			85, 85, // Attack & Defense
			55, 55, // Special Attack & Defense
			50			
		) {}
	}


	//Mawile Pokemon Class
	public class Mawile : Pokemon
	{

		public Mawile(string nickname, int level)
		: base(
				303,
				SpecieMawile.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Mawile() : base(
			303,
			SpecieMawile.Instance, // Pokemon Specie
			Steel.Instance, Fairy.Instance			
		) {}
	}
}