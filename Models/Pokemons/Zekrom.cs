using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Zekrom Specie to store common natural stats of every {'abilities': ['teravolt'], 'base_experience': 306, 'height': 29, 'id': 644, 'moves': ['thunder-punch', 'cut', 'fly', 'hyper-beam', 'strength', 'dragon-rage', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'double-team', 'light-screen', 'reflect', 'flash', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'protect', 'outrage', 'swagger', 'steel-wing', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dragon-breath', 'hidden-power', 'rain-dance', 'crunch', 'ancient-power', 'shadow-ball', 'rock-smash', 'facade', 'imprison', 'secret-power', 'hyper-voice', 'rock-tomb', 'signal-beam', 'dragon-claw', 'shock-wave', 'roost', 'tailwind', 'payback', 'fling', 'magnet-rise', 'dragon-pulse', 'focus-blast', 'earth-power', 'giga-impact', 'shadow-claw', 'thunder-fang', 'zen-headbutt', 'flash-cannon', 'draco-meteor', 'stone-edge', 'charge-beam', 'hone-claws', 'round', 'echoed-voice', 'volt-switch', 'dragon-tail', 'wild-charge', 'bolt-strike', 'fusion-bolt', 'noble-roar', 'confide', 'brutal-swing'], 'name': 'zekrom', 'stats': {'hp': 100, 'attack': 150, 'defense': 120, 'special-attack': 120, 'special-defense': 100, 'speed': 90}, 'types': ['dragon', 'electric'], 'weight': 3450, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'black', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ゼクロム', 'ko': '제크로무', 'zh-Hant': '捷克羅姆', 'fr': 'Zekrom', 'de': 'Zekrom', 'es': 'Zekrom', 'it': 'Zekrom', 'en': 'Zekrom', 'ja': 'ゼクロム', 'zh-Hans': '捷克罗姆'}, 'genera': {'ja-Hrkt': 'こくいんポケモン', 'ko': '흑음포켓몬', 'zh-Hant': '黑陰寶可夢', 'fr': 'Pokémon Noir Idéal', 'de': 'Reines Schwarz', 'es': 'Pokémon Negro Puro', 'it': 'Pokémon Nero Ideale', 'en': 'Deep Black Pokémon', 'ja': 'こくいんポケモン', 'zh-Hans': '黑阴宝可梦'}}
	public class SpecieZekrom : PokemonSpecie
	{
#nullable enable
		private static SpecieZekrom? _instance = null;
#nullable restore
        public static SpecieZekrom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZekrom();
                }
                return _instance;
            }
        }

		public SpecieZekrom() : base(
			"Zekrom",
			100, // HPs
			150, 120, // Attack & Defense
			120, 100, // Special Attack & Defense
			90			
		) {}
	}


	//Zekrom Pokemon Class
	public class Zekrom : Pokemon
	{

		public Zekrom(string nickname, int level) : base(
			644,
			SpecieZekrom.Instance, // Pokemon Specie
			nickname, level,
			Dragon.Instance, Electric.Instance			
		) {}

		public Zekrom() : base(
			644,
			SpecieZekrom.Instance, // Pokemon Specie
			Dragon.Instance, Electric.Instance			
		) {}
	}
}