using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Meloetta-Aria Specie to store common natural stats of every {'abilities': ['serene-grace'], 'base_experience': 270, 'height': 6, 'id': 648, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'sing', 'psybeam', 'hyper-beam', 'low-kick', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'confusion', 'psychic', 'quick-attack', 'double-team', 'light-screen', 'dream-eater', 'flash', 'rest', 'substitute', 'snore', 'protect', 'perish-song', 'swagger', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'uproar', 'facade', 'focus-punch', 'helping-hand', 'trick', 'role-play', 'magic-coat', 'recycle', 'brick-break', 'knock-off', 'skill-swap', 'snatch', 'secret-power', 'teeter-dance', 'hyper-voice', 'signal-beam', 'covet', 'calm-mind', 'shock-wave', 'gravity', 'wake-up-slap', 'u-turn', 'close-combat', 'payback', 'embargo', 'fling', 'last-resort', 'drain-punch', 'focus-blast', 'energy-ball', 'giga-impact', 'shadow-claw', 'zen-headbutt', 'trick-room', 'stone-edge', 'grass-knot', 'charge-beam', 'hone-claws', 'wonder-room', 'psyshock', 'telekinesis', 'magic-room', 'low-sweep', 'round', 'echoed-voice', 'acrobatics', 'retaliate', 'work-up', 'dual-chop', 'relic-song', 'confide', 'dazzling-gleam', 'power-up-punch'], 'name': 'meloetta-aria', 'stats': {'hp': 100, 'attack': 77, 'defense': 77, 'special-attack': 128, 'special-defense': 128, 'speed': 90}, 'types': ['normal', 'psychic'], 'weight': 65, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'white', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'メロエッタ', 'ko': '메로엣타', 'zh-Hant': '美洛耶塔', 'fr': 'Meloetta', 'de': 'Meloetta', 'es': 'Meloetta', 'it': 'Meloetta', 'en': 'Meloetta', 'ja': 'メロエッタ', 'zh-Hans': '美洛耶塔'}, 'genera': {'ja-Hrkt': 'せんりつポケモン', 'ko': '선율포켓몬', 'zh-Hant': '旋律寶可夢', 'fr': 'Pokémon Mélodie', 'de': 'Melodie', 'es': 'Pokémon Melodía', 'it': 'Pokémon Melodia', 'en': 'Melody Pokémon', 'ja': 'せんりつポケモン', 'zh-Hans': '旋律宝可梦'}}
	public class SpecieMeloettaAria : PokemonSpecie
	{
#nullable enable
		private static SpecieMeloettaAria? _instance = null;
#nullable restore
        public static SpecieMeloettaAria Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMeloettaAria();
                }
                return _instance;
            }
        }

		public SpecieMeloettaAria() : base(
			"Meloetta-Aria",
			100, // HPs
			77, 77, // Attack & Defense
			128, 128, // Special Attack & Defense
			90			
		) {}
	}


	//Meloetta-Aria Pokemon Class
	public class MeloettaAria : Pokemon
	{

		public MeloettaAria(string nickname, int level) : base(
			648,
			SpecieMeloettaAria.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance, Psychic.Instance			
		) {}

		public MeloettaAria() : base(
			648,
			SpecieMeloettaAria.Instance, // Pokemon Specie
			Normal.Instance, Psychic.Instance			
		) {}
	}
}