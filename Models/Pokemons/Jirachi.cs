using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Jirachi Specie to store common natural stats of every {'abilities': ['serene-grace'], 'base_experience': 270, 'height': 3, 'id': 385, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'headbutt', 'body-slam', 'double-edge', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'confusion', 'psychic', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'metronome', 'swift', 'dream-eater', 'flash', 'rest', 'substitute', 'nightmare', 'snore', 'protect', 'mud-slap', 'icy-wind', 'sandstorm', 'endure', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'ancient-power', 'shadow-ball', 'future-sight', 'uproar', 'facade', 'helping-hand', 'trick', 'wish', 'magic-coat', 'recycle', 'skill-swap', 'refresh', 'secret-power', 'cosmic-power', 'signal-beam', 'aerial-ace', 'iron-defense', 'calm-mind', 'shock-wave', 'water-pulse', 'doom-desire', 'gravity', 'healing-wish', 'natural-gift', 'u-turn', 'fling', 'lucky-chant', 'last-resort', 'drain-punch', 'energy-ball', 'giga-impact', 'zen-headbutt', 'flash-cannon', 'trick-room', 'iron-head', 'stealth-rock', 'grass-knot', 'charge-beam', 'psyshock', 'telekinesis', 'magic-room', 'round', 'confide', 'dazzling-gleam', 'power-up-punch'], 'name': 'jirachi', 'stats': {'hp': 100, 'attack': 100, 'defense': 100, 'special-attack': 100, 'special-defense': 100, 'speed': 100}, 'types': ['steel', 'psychic'], 'weight': 11, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'yellow', 'shape': 'humanoid', 'habitat': 'mountain', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ジラーチ', 'roomaji': 'Jirachi', 'ko': '지라치', 'zh-Hant': '基拉祈', 'fr': 'Jirachi', 'de': 'Jirachi', 'es': 'Jirachi', 'it': 'Jirachi', 'en': 'Jirachi', 'ja': 'ジラーチ', 'zh-Hans': '基拉祈'}, 'genera': {'ja-Hrkt': 'ねがいごとポケモン', 'ko': '희망사항포켓몬', 'zh-Hant': '祈願寶可夢', 'fr': 'Pokémon Souhait', 'de': 'Wünscher', 'es': 'Pokémon Deseo', 'it': 'Pokémon Desiderio', 'en': 'Wish Pokémon', 'ja': 'ねがいごとポケモン', 'zh-Hans': '祈愿宝可梦'}}
	public class SpecieJirachi : PokemonSpecie
	{
#nullable enable
		private static SpecieJirachi? _instance = null;
#nullable restore
        public static SpecieJirachi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieJirachi();
                }
                return _instance;
            }
        }

		public SpecieJirachi() : base(
			"Jirachi",
			100, // HPs
			100, 100, // Attack & Defense
			100, 100, // Special Attack & Defense
			100			
		) {}
	}


	//Jirachi Pokemon Class
	public class Jirachi : Pokemon
	{

		public Jirachi(string nickname, int level)
		: base(
				385,
				SpecieJirachi.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Jirachi() : base(
			385,
			SpecieJirachi.Instance, // Pokemon Specie
			Steel.Instance, Psychic.Instance			
		) {}
	}
}