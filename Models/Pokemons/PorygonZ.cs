using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Porygon-Z Specie to store common natural stats of every {'abilities': ['adaptability', 'download', 'analytic'], 'base_experience': 241, 'height': 9, 'id': 474, 'moves': ['tackle', 'ice-beam', 'blizzard', 'psybeam', 'hyper-beam', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'agility', 'double-team', 'recover', 'swift', 'dream-eater', 'flash', 'rest', 'conversion', 'tri-attack', 'substitute', 'thief', 'snore', 'conversion-2', 'protect', 'zap-cannon', 'icy-wind', 'lock-on', 'endure', 'swagger', 'sleep-talk', 'return', 'frustration', 'pain-split', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'facade', 'trick', 'magic-coat', 'recycle', 'secret-power', 'signal-beam', 'aerial-ace', 'shock-wave', 'gravity', 'natural-gift', 'embargo', 'last-resort', 'magnet-rise', 'dark-pulse', 'giga-impact', 'nasty-plot', 'zen-headbutt', 'trick-room', 'discharge', 'charge-beam', 'wonder-room', 'psyshock', 'foul-play', 'round', 'electroweb', 'confide'], 'name': 'porygon-z', 'stats': {'hp': 85, 'attack': 80, 'defense': 70, 'special-attack': 135, 'special-defense': 75, 'speed': 90}, 'types': ['normal'], 'weight': 340, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 30, 'color': 'red', 'shape': 'arms', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ポリゴンＺ', 'roomaji': 'PorygonZ', 'ko': '폴리곤Z', 'zh-Hant': '多邊獸Ｚ', 'fr': 'Porygon-Z', 'de': 'Porygon-Z', 'es': 'Porygon-Z', 'it': 'Porygon-Z', 'en': 'Porygon-Z', 'ja': 'ポリゴンＺ', 'zh-Hans': '多边兽Ｚ'}, 'genera': {'ja-Hrkt': 'バーチャルポケモン', 'ko': '가상포켓몬', 'zh-Hant': '虛擬寶可夢', 'fr': 'Pokémon Virtuel', 'de': 'Virtuell', 'es': 'Pokémon Virtual', 'it': 'Pokémon Virtuale', 'en': 'Virtual Pokémon', 'ja': 'バーチャルポケモン', 'zh-Hans': '虚拟宝可梦'}}
	public class SpeciePorygonZ : PokemonSpecie
	{
#nullable enable
		private static SpeciePorygonZ? _instance = null;
#nullable restore
        public static SpeciePorygonZ Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePorygonZ();
                }
                return _instance;
            }
        }

		public SpeciePorygonZ() : base(
			"Porygon-Z",
			85, // HPs
			80, 70, // Attack & Defense
			135, 75, // Special Attack & Defense
			90			
		) {}
	}


	//Porygon-Z Pokemon Class
	public class PorygonZ : Pokemon
	{

		public PorygonZ(string nickname, int level) : base(
			474,
			SpeciePorygonZ.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public PorygonZ() : base(
			474,
			SpeciePorygonZ.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}