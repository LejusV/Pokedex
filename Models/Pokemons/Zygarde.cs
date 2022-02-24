using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Zygarde Specie to store common natural stats of every {'abilities': ['aura-break'], 'base_experience': 270, 'height': 50, 'id': 718, 'moves': ['bind', 'bite', 'hyper-beam', 'strength', 'earthquake', 'dig', 'toxic', 'double-team', 'haze', 'glare', 'rest', 'rock-slide', 'substitute', 'snore', 'spite', 'protect', 'outrage', 'sandstorm', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'dragon-breath', 'iron-tail', 'hidden-power', 'sunny-day', 'crunch', 'extreme-speed', 'rock-smash', 'facade', 'superpower', 'brick-break', 'secret-power', 'camouflage', 'hyper-voice', 'block', 'dragon-dance', 'shock-wave', 'dragon-pulse', 'focus-blast', 'earth-power', 'giga-impact', 'zen-headbutt', 'draco-meteor', 'stone-edge', 'grass-knot', 'sludge-wave', 'coil', 'round', 'bulldoze', 'dragon-tail', 'confide', 'lands-wrath'], 'name': 'zygarde', 'stats': {'hp': 108, 'attack': 100, 'defense': 121, 'special-attack': 81, 'special-defense': 95, 'speed': 95}, 'types': ['dragon', 'ground'], 'weight': 3050, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'green', 'shape': 'squiggle', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ジガルデ', 'ko': '지가르데', 'zh-Hant': '基格爾德', 'fr': 'Zygarde', 'de': 'Zygarde', 'es': 'Zygarde', 'it': 'Zygarde', 'en': 'Zygarde', 'ja': 'ジガルデ', 'zh-Hans': '基格尔德'}, 'genera': {'ja-Hrkt': 'ちつじょポケモン', 'ko': '질서포켓몬', 'zh-Hant': '秩序寶可夢', 'fr': 'Pokémon Équilibre', 'de': 'Ordnung', 'es': 'Pokémon Equilibrio', 'it': 'Pokémon Equilibrio', 'en': 'Order Pokémon', 'ja': 'ちつじょポケモン', 'zh-Hans': '秩序宝可梦'}}
	public class SpecieZygarde : PokemonSpecie
	{
#nullable enable
		private static SpecieZygarde? _instance = null;
#nullable restore
        public static SpecieZygarde Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZygarde();
                }
                return _instance;
            }
        }

		public SpecieZygarde() : base(
			"Zygarde",
			108, // HPs
			100, 121, // Attack & Defense
			81, 95, // Special Attack & Defense
			95			
		) {}
	}


	//Zygarde Pokemon Class
	public class Zygarde : Pokemon
	{

		public Zygarde(string nickname, int level)
		: base(
				718,
				SpecieZygarde.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Zygarde() : base(
			718,
			SpecieZygarde.Instance, // Pokemon Specie
			Dragon.Instance, Ground.Instance			
		) {}
	}
}