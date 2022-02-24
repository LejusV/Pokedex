using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Skitty Specie to store common natural stats of every {'abilities': ['cute-charm', 'normalize', 'wonder-skin'], 'base_experience': 52, 'height': 6, 'id': 300, 'moves': ['double-slap', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'tail-whip', 'growl', 'sing', 'ice-beam', 'blizzard', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'mimic', 'double-team', 'defense-curl', 'swift', 'dream-eater', 'flash', 'rest', 'substitute', 'snore', 'protect', 'feint-attack', 'mud-slap', 'foresight', 'icy-wind', 'endure', 'charm', 'rollout', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'baton-pass', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'fake-out', 'uproar', 'facade', 'helping-hand', 'wish', 'assist', 'secret-power', 'hyper-voice', 'fake-tears', 'tickle', 'cosmic-power', 'covet', 'calm-mind', 'shock-wave', 'water-pulse', 'wake-up-slap', 'natural-gift', 'payback', 'copycat', 'last-resort', 'sucker-punch', 'mud-bomb', 'zen-headbutt', 'captivate', 'grass-knot', 'charge-beam', 'simple-beam', 'round', 'echoed-voice', 'retaliate', 'work-up', 'wild-charge', 'disarming-voice', 'play-rough', 'confide'], 'name': 'skitty', 'stats': {'hp': 50, 'attack': 45, 'defense': 45, 'special-attack': 35, 'special-defense': 35, 'speed': 50}, 'types': ['normal'], 'weight': 110, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 6, 'capture_rate': 255, 'color': 'pink', 'shape': 'quadruped', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'fast', 'egg_groups': ['ground', 'fairy'], 'names': {'ja-Hrkt': 'エネコ', 'roomaji': 'Eneco', 'ko': '에나비', 'zh-Hant': '向尾喵', 'fr': 'Skitty', 'de': 'Eneco', 'es': 'Skitty', 'it': 'Skitty', 'en': 'Skitty', 'ja': 'エネコ', 'zh-Hans': '向尾喵'}, 'genera': {'ja-Hrkt': 'こねこポケモン', 'ko': '작은고양이포켓몬', 'zh-Hant': '小貓寶可夢', 'fr': 'Pokémon Chaton', 'de': 'Kätzchen', 'es': 'Pokémon Gatito', 'it': 'Pokémon Micio', 'en': 'Kitten Pokémon', 'ja': 'こねこポケモン', 'zh-Hans': '小猫宝可梦'}}
	public class SpecieSkitty : PokemonSpecie
	{
#nullable enable
		private static SpecieSkitty? _instance = null;
#nullable restore
        public static SpecieSkitty Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSkitty();
                }
                return _instance;
            }
        }

		public SpecieSkitty() : base(
			"Skitty",
			50, // HPs
			45, 45, // Attack & Defense
			35, 35, // Special Attack & Defense
			50			
		) {}
	}


	//Skitty Pokemon Class
	public class Skitty : Pokemon
	{

		public Skitty(string nickname, int level)
		: base(
				300,
				SpecieSkitty.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Skitty() : base(
			300,
			SpecieSkitty.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}