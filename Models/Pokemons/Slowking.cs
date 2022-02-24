using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Slowking Specie to store common natural stats of every {'abilities': ['oblivious', 'own-tempo', 'regenerator'], 'base_experience': 172, 'height': 20, 'id': 199, 'moves': ['mega-punch', 'ice-punch', 'mega-kick', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'growl', 'disable', 'flamethrower', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'counter', 'seismic-toss', 'strength', 'thunder-wave', 'earthquake', 'dig', 'toxic', 'confusion', 'psychic', 'mimic', 'double-team', 'light-screen', 'fire-blast', 'swift', 'dream-eater', 'flash', 'rest', 'substitute', 'nightmare', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'icy-wind', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'whirlpool', 'hail', 'facade', 'focus-punch', 'trick', 'magic-coat', 'recycle', 'brick-break', 'yawn', 'skill-swap', 'secret-power', 'dive', 'signal-beam', 'iron-defense', 'block', 'calm-mind', 'water-pulse', 'brine', 'natural-gift', 'fling', 'trump-card', 'aqua-tail', 'power-gem', 'drain-punch', 'focus-blast', 'giga-impact', 'nasty-plot', 'avalanche', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'wonder-room', 'psyshock', 'telekinesis', 'foul-play', 'after-you', 'round', 'echoed-voice', 'scald', 'heal-pulse', 'incinerate', 'quash', 'bulldoze', 'dragon-tail', 'confide', 'power-up-punch'], 'name': 'slowking', 'stats': {'hp': 95, 'attack': 75, 'defense': 80, 'special-attack': 100, 'special-defense': 110, 'speed': 30}, 'types': ['water', 'psychic'], 'weight': 795, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 70, 'color': 'pink', 'shape': 'upright', 'habitat': 'waters-edge', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['monster', 'water1'], 'names': {'ja-Hrkt': 'ヤドキング', 'roomaji': 'Yadoking', 'ko': '야도킹', 'zh-Hant': '呆呆王', 'fr': 'Roigada', 'de': 'Laschoking', 'es': 'Slowking', 'it': 'Slowking', 'en': 'Slowking', 'ja': 'ヤドキング', 'zh-Hans': '呆呆王'}, 'genera': {'ja-Hrkt': 'おうじゃポケモン', 'ko': '임금포켓몬', 'zh-Hant': '王者寶可夢', 'fr': 'Pokémon Royal', 'de': 'Monarch', 'es': 'Pokémon Regio', 'it': 'Pokémon Reale', 'en': 'Royal Pokémon', 'ja': 'おうじゃポケモン', 'zh-Hans': '王者宝可梦'}}
	public class SpecieSlowking : PokemonSpecie
	{
#nullable enable
		private static SpecieSlowking? _instance = null;
#nullable restore
        public static SpecieSlowking Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSlowking();
                }
                return _instance;
            }
        }

		public SpecieSlowking() : base(
			"Slowking",
			95, // HPs
			75, 80, // Attack & Defense
			100, 110, // Special Attack & Defense
			30			
		) {}
	}


	//Slowking Pokemon Class
	public class Slowking : Pokemon
	{

		public Slowking(string nickname, int level)
		: base(
				199,
				SpecieSlowking.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Slowking() : base(
			199,
			SpecieSlowking.Instance, // Pokemon Specie
			Water.Instance, Psychic.Instance			
		) {}
	}
}