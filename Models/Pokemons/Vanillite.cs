using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Vanillite Specie to store common natural stats of every {'abilities': ['ice-body', 'snow-cloak', 'weak-armor'], 'base_experience': 61, 'height': 4, 'id': 582, 'moves': ['mist', 'ice-beam', 'blizzard', 'toxic', 'double-team', 'harden', 'light-screen', 'acid-armor', 'explosion', 'rest', 'substitute', 'snore', 'powder-snow', 'protect', 'icy-wind', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'mirror-coat', 'uproar', 'hail', 'facade', 'taunt', 'magic-coat', 'imprison', 'secret-power', 'astonish', 'signal-beam', 'sheer-cold', 'icicle-spear', 'iron-defense', 'water-pulse', 'natural-gift', 'magnet-rise', 'avalanche', 'ice-shard', 'mirror-shot', 'flash-cannon', 'autotomize', 'round', 'frost-breath', 'confide'], 'name': 'vanillite', 'stats': {'hp': 36, 'attack': 50, 'defense': 50, 'special-attack': 65, 'special-defense': 60, 'speed': 44}, 'types': ['ice'], 'weight': 57, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'white', 'shape': 'blob', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'バニプッチ', 'ko': '바닐프티', 'zh-Hant': '迷你冰', 'fr': 'Sorbébé', 'de': 'Gelatini', 'es': 'Vanillite', 'it': 'Vanillite', 'en': 'Vanillite', 'ja': 'バニプッチ', 'zh-Hans': '迷你冰'}, 'genera': {'ja-Hrkt': 'しんせつポケモン', 'ko': '신설포켓몬', 'zh-Hant': '新雪寶可夢', 'fr': 'Pokémon Poudreuse', 'de': 'Neuschnee', 'es': 'Pokémon Nieve Fresca', 'it': 'Pokémon Nevefresca', 'en': 'Fresh Snow Pokémon', 'ja': 'しんせつポケモン', 'zh-Hans': '新雪宝可梦'}}
	public class SpecieVanillite : PokemonSpecie
	{
#nullable enable
		private static SpecieVanillite? _instance = null;
#nullable restore
        public static SpecieVanillite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVanillite();
                }
                return _instance;
            }
        }

		public SpecieVanillite() : base(
			"Vanillite",
			36, // HPs
			50, 50, // Attack & Defense
			65, 60, // Special Attack & Defense
			44			
		) {}
	}


	//Vanillite Pokemon Class
	public class Vanillite : Pokemon
	{

		public Vanillite(string nickname, int level)
		: base(
				582,
				SpecieVanillite.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Vanillite() : base(
			582,
			SpecieVanillite.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
	}
}