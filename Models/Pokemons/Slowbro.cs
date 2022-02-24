using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Slowbro Specie to store common natural stats of every {'abilities': ['oblivious', 'own-tempo', 'regenerator'], 'base_experience': 172, 'height': 16, 'id': 80, 'moves': ['mega-punch', 'pay-day', 'ice-punch', 'mega-kick', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'growl', 'disable', 'flamethrower', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'thunder-wave', 'earthquake', 'fissure', 'dig', 'toxic', 'confusion', 'psychic', 'rage', 'teleport', 'mimic', 'double-team', 'withdraw', 'light-screen', 'reflect', 'bide', 'fire-blast', 'swift', 'skull-bash', 'amnesia', 'dream-eater', 'flash', 'psywave', 'rest', 'tri-attack', 'substitute', 'nightmare', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'icy-wind', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'whirlpool', 'hail', 'facade', 'focus-punch', 'trick', 'magic-coat', 'recycle', 'brick-break', 'yawn', 'skill-swap', 'secret-power', 'dive', 'slack-off', 'signal-beam', 'aerial-ace', 'iron-defense', 'block', 'calm-mind', 'water-pulse', 'brine', 'natural-gift', 'fling', 'aqua-tail', 'drain-punch', 'focus-blast', 'giga-impact', 'avalanche', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'wonder-room', 'psyshock', 'telekinesis', 'foul-play', 'after-you', 'round', 'echoed-voice', 'scald', 'heal-pulse', 'incinerate', 'bulldoze', 'confide'], 'name': 'slowbro', 'stats': {'hp': 95, 'attack': 75, 'defense': 110, 'special-attack': 100, 'special-defense': 80, 'speed': 30}, 'types': ['water', 'psychic'], 'weight': 785, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'pink', 'shape': 'upright', 'habitat': 'waters-edge', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['monster', 'water1'], 'names': {'ja-Hrkt': 'ヤドラン', 'roomaji': 'Yadoran', 'ko': '야도란', 'zh-Hant': '呆殼獸', 'fr': 'Flagadoss', 'de': 'Lahmus', 'es': 'Slowbro', 'it': 'Slowbro', 'en': 'Slowbro', 'ja': 'ヤドラン', 'zh-Hans': '呆壳兽'}, 'genera': {'ja-Hrkt': 'やどかりポケモン', 'ko': '기생포켓몬', 'zh-Hant': '寄居蟹寶可夢', 'fr': 'Pokémon Symbiose', 'de': 'Symbiose', 'es': 'Pokémon Ermitaño', 'it': 'Pokémon Paguro', 'en': 'Hermit Crab Pokémon', 'ja': 'やどかりポケモン', 'zh-Hans': '寄居蟹宝可梦'}}
	public class SpecieSlowbro : PokemonSpecie
	{
#nullable enable
		private static SpecieSlowbro? _instance = null;
#nullable restore
        public static SpecieSlowbro Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSlowbro();
                }
                return _instance;
            }
        }

		public SpecieSlowbro() : base(
			"Slowbro",
			95, // HPs
			75, 110, // Attack & Defense
			100, 80, // Special Attack & Defense
			30			
		) {}
	}


	//Slowbro Pokemon Class
	public class Slowbro : Pokemon
	{

		public Slowbro(string nickname, int level)
		: base(
				80,
				SpecieSlowbro.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Slowbro() : base(
			80,
			SpecieSlowbro.Instance, // Pokemon Specie
			Water.Instance, Psychic.Instance			
		) {}
	}
}