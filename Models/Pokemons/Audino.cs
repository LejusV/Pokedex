using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Audino Specie to store common natural stats of every {'abilities': ['healer', 'regenerator', 'klutz'], 'base_experience': 390, 'height': 11, 'id': 531, 'moves': ['pound', 'double-slap', 'fire-punch', 'ice-punch', 'thunder-punch', 'take-down', 'double-edge', 'growl', 'flamethrower', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'low-kick', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'psychic', 'double-team', 'light-screen', 'reflect', 'fire-blast', 'amnesia', 'dream-eater', 'flash', 'rest', 'substitute', 'snore', 'protect', 'sweet-kiss', 'icy-wind', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'pain-split', 'encore', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'facade', 'focus-punch', 'helping-hand', 'role-play', 'wish', 'magic-coat', 'yawn', 'knock-off', 'skill-swap', 'refresh', 'snatch', 'secret-power', 'hyper-voice', 'signal-beam', 'covet', 'calm-mind', 'gravity', 'healing-wish', 'fling', 'lucky-chant', 'last-resort', 'drain-punch', 'zen-headbutt', 'trick-room', 'grass-knot', 'charge-beam', 'psyshock', 'telekinesis', 'simple-beam', 'entrainment', 'after-you', 'round', 'echoed-voice', 'heal-pulse', 'incinerate', 'retaliate', 'bestow', 'work-up', 'wild-charge', 'disarming-voice', 'draining-kiss', 'misty-terrain', 'play-nice', 'confide', 'dazzling-gleam', 'baby-doll-eyes', 'power-up-punch'], 'name': 'audino', 'stats': {'hp': 103, 'attack': 60, 'defense': 86, 'special-attack': 60, 'special-defense': 86, 'speed': 50}, 'types': ['normal'], 'weight': 310, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'pink', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'fast', 'egg_groups': ['fairy'], 'names': {'ja-Hrkt': 'タブンネ', 'ko': '다부니', 'zh-Hant': '差不多娃娃', 'fr': 'Nanméouïe', 'de': 'Ohrdoch', 'es': 'Audino', 'it': 'Audino', 'en': 'Audino', 'ja': 'タブンネ', 'zh-Hans': '差不多娃娃'}, 'genera': {'ja-Hrkt': 'ヒヤリングポケモン', 'ko': '히어링포켓몬', 'zh-Hant': '聽力寶可夢', 'fr': 'Pokémon Audition', 'de': 'Gehör', 'es': 'Pokémon Escucha', 'it': 'Pokémon Ascolto', 'en': 'Hearing Pokémon', 'ja': 'ヒヤリングポケモン', 'zh-Hans': '听力宝可梦'}}
	public class SpecieAudino : PokemonSpecie
	{
#nullable enable
		private static SpecieAudino? _instance = null;
#nullable restore
        public static SpecieAudino Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAudino();
                }
                return _instance;
            }
        }

		public SpecieAudino() : base(
			"Audino",
			103, // HPs
			60, 86, // Attack & Defense
			60, 86, // Special Attack & Defense
			50			
		) {}
	}


	//Audino Pokemon Class
	public class Audino : Pokemon
	{

		public Audino(string nickname, int level)
		: base(
				531,
				SpecieAudino.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Audino() : base(
			531,
			SpecieAudino.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}