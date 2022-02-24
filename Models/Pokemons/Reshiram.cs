using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Reshiram Specie to store common natural stats of every {'abilities': ['turboblaze'], 'base_experience': 306, 'height': 32, 'id': 643, 'moves': ['cut', 'fly', 'flamethrower', 'hyper-beam', 'strength', 'solar-beam', 'dragon-rage', 'toxic', 'psychic', 'double-team', 'light-screen', 'reflect', 'fire-blast', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'protect', 'outrage', 'swagger', 'steel-wing', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dragon-breath', 'hidden-power', 'sunny-day', 'crunch', 'ancient-power', 'shadow-ball', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'imprison', 'secret-power', 'hyper-voice', 'overheat', 'rock-tomb', 'extrasensory', 'dragon-claw', 'roost', 'tailwind', 'payback', 'fling', 'dragon-pulse', 'focus-blast', 'earth-power', 'giga-impact', 'shadow-claw', 'fire-fang', 'zen-headbutt', 'draco-meteor', 'stone-edge', 'hone-claws', 'flame-charge', 'round', 'echoed-voice', 'incinerate', 'dragon-tail', 'blue-flare', 'fusion-flare', 'noble-roar', 'confide', 'brutal-swing'], 'name': 'reshiram', 'stats': {'hp': 100, 'attack': 120, 'defense': 100, 'special-attack': 150, 'special-defense': 120, 'speed': 90}, 'types': ['dragon', 'fire'], 'weight': 3300, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'white', 'shape': 'wings', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'レシラム', 'ko': '레시라무', 'zh-Hant': '萊希拉姆', 'fr': 'Reshiram', 'de': 'Reshiram', 'es': 'Reshiram', 'it': 'Reshiram', 'en': 'Reshiram', 'ja': 'レシラム', 'zh-Hans': '莱希拉姆'}, 'genera': {'ja-Hrkt': 'はくようポケモン', 'ko': '백양포켓몬', 'zh-Hant': '白陽寶可夢', 'fr': 'Pokémon Blanc Réel', 'de': 'Wahres Weiß', 'es': 'Pokémon Blanco Veraz', 'it': 'Pokémon Bianco Verità', 'en': 'Vast White Pokémon', 'ja': 'はくようポケモン', 'zh-Hans': '白阳宝可梦'}}
	public class SpecieReshiram : PokemonSpecie
	{
#nullable enable
		private static SpecieReshiram? _instance = null;
#nullable restore
        public static SpecieReshiram Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieReshiram();
                }
                return _instance;
            }
        }

		public SpecieReshiram() : base(
			"Reshiram",
			100, // HPs
			120, 100, // Attack & Defense
			150, 120, // Special Attack & Defense
			90			
		) {}
	}


	//Reshiram Pokemon Class
	public class Reshiram : Pokemon
	{

		public Reshiram(string nickname, int level)
		: base(
				643,
				SpecieReshiram.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Reshiram() : base(
			643,
			SpecieReshiram.Instance, // Pokemon Specie
			Dragon.Instance, Fire.Instance			
		) {}
	}
}