using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mew Specie to store common natural stats of every {'abilities': ['synchronize'], 'base_experience': 270, 'height': 4, 'id': 151, 'moves': ['pound', 'mega-punch', 'pay-day', 'fire-punch', 'ice-punch', 'thunder-punch', 'razor-wind', 'swords-dance', 'cut', 'whirlwind', 'fly', 'bind', 'mega-kick', 'headbutt', 'horn-drill', 'body-slam', 'take-down', 'double-edge', 'roar', 'flamethrower', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'submission', 'low-kick', 'counter', 'seismic-toss', 'strength', 'mega-drain', 'solar-beam', 'string-shot', 'dragon-rage', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'fissure', 'dig', 'toxic', 'psychic', 'hypnosis', 'rage', 'teleport', 'night-shade', 'mimic', 'double-team', 'defense-curl', 'barrier', 'light-screen', 'reflect', 'bide', 'metronome', 'self-destruct', 'egg-bomb', 'fire-blast', 'waterfall', 'swift', 'skull-bash', 'amnesia', 'soft-boiled', 'dream-eater', 'leech-life', 'sky-attack', 'transform', 'flash', 'psywave', 'explosion', 'rest', 'rock-slide', 'tri-attack', 'super-fang', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'spite', 'protect', 'feint-attack', 'sludge-bomb', 'mud-slap', 'zap-cannon', 'icy-wind', 'detect', 'outrage', 'sandstorm', 'giga-drain', 'endure', 'rollout', 'false-swipe', 'swagger', 'fury-cutter', 'steel-wing', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'pain-split', 'dynamic-punch', 'dragon-breath', 'baton-pass', 'sweet-scent', 'iron-tail', 'synthesis', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'ancient-power', 'shadow-ball', 'rock-smash', 'whirlpool', 'fake-out', 'uproar', 'heat-wave', 'hail', 'torment', 'will-o-wisp', 'facade', 'focus-punch', 'nature-power', 'taunt', 'helping-hand', 'trick', 'role-play', 'superpower', 'magic-coat', 'recycle', 'brick-break', 'knock-off', 'endeavor', 'skill-swap', 'snatch', 'secret-power', 'dive', 'hyper-voice', 'air-cutter', 'overheat', 'rock-tomb', 'silver-wind', 'signal-beam', 'bullet-seed', 'aerial-ace', 'iron-defense', 'block', 'dragon-claw', 'bulk-up', 'bounce', 'covet', 'calm-mind', 'shock-wave', 'water-pulse', 'roost', 'gravity', 'gyro-ball', 'brine', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'payback', 'embargo', 'fling', 'gastro-acid', 'me-first', 'last-resort', 'worry-seed', 'sucker-punch', 'magnet-rise', 'aura-sphere', 'rock-polish', 'poison-jab', 'dark-pulse', 'aqua-tail', 'seed-bomb', 'x-scissor', 'dragon-pulse', 'drain-punch', 'vacuum-wave', 'focus-blast', 'energy-ball', 'earth-power', 'giga-impact', 'nasty-plot', 'avalanche', 'shadow-claw', 'zen-headbutt', 'flash-cannon', 'rock-climb', 'defog', 'trick-room', 'gunk-shot', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'grass-knot', 'bug-bite', 'charge-beam', 'ominous-wind', 'hone-claws', 'wonder-room', 'psyshock', 'venoshock', 'telekinesis', 'magic-room', 'smack-down', 'sludge-wave', 'flame-charge', 'low-sweep', 'foul-play', 'after-you', 'round', 'echoed-voice', 'ally-switch', 'scald', 'sky-drop', 'incinerate', 'quash', 'acrobatics', 'reflect-type', 'retaliate', 'volt-switch', 'struggle-bug', 'bulldoze', 'frost-breath', 'dragon-tail', 'work-up', 'electroweb', 'wild-charge', 'drill-run', 'dual-chop', 'snarl', 'confide', 'dazzling-gleam', 'infestation', 'power-up-punch', 'smart-strike', 'brutal-swing', 'aurora-veil'], 'name': 'mew', 'stats': {'hp': 100, 'attack': 100, 'defense': 100, 'special-attack': 100, 'special-defense': 100, 'speed': 100}, 'types': ['psychic'], 'weight': 40, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 45, 'color': 'pink', 'shape': 'upright', 'habitat': 'rare', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ミュウ', 'roomaji': 'Mew', 'ko': '뮤', 'zh-Hant': '夢幻', 'fr': 'Mew', 'de': 'Mew', 'es': 'Mew', 'it': 'Mew', 'en': 'Mew', 'ja': 'ミュウ', 'zh-Hans': '梦幻'}, 'genera': {'ja-Hrkt': 'しんしゅポケモン', 'ko': '신종포켓몬', 'zh-Hant': '新種寶可夢', 'fr': 'Pokémon Nouveau', 'de': 'Neue Art', 'es': 'Pokémon N. Especie', 'it': 'Pokémon Novaspecie', 'en': 'New Species Pokémon', 'ja': 'しんしゅポケモン', 'zh-Hans': '新种宝可梦'}}
	public class SpecieMew : PokemonSpecie
	{
#nullable enable
		private static SpecieMew? _instance = null;
#nullable restore
        public static SpecieMew Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMew();
                }
                return _instance;
            }
        }

		public SpecieMew() : base(
			"Mew",
			100, // HPs
			100, 100, // Attack & Defense
			100, 100, // Special Attack & Defense
			100			
		) {}
	}


	//Mew Pokemon Class
	public class Mew : Pokemon
	{

		public Mew(string nickname, int level)
		: base(
				151,
				SpecieMew.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Mew(int level)
		: base(
				151,
				SpecieMew.Instance, // Pokemon Specie
				"Mew", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Mew() : base(
			151,
			SpecieMew.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}