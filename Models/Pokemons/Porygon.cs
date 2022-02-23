using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Porygon Specie to store common natural stats of every {'abilities': ['trace', 'download', 'analytic'], 'base_experience': 79, 'height': 8, 'id': 137, 'moves': ['tackle', 'take-down', 'double-edge', 'ice-beam', 'blizzard', 'psybeam', 'hyper-beam', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'agility', 'rage', 'teleport', 'mimic', 'double-team', 'recover', 'reflect', 'bide', 'swift', 'skull-bash', 'dream-eater', 'flash', 'psywave', 'rest', 'sharpen', 'conversion', 'tri-attack', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'conversion-2', 'protect', 'zap-cannon', 'icy-wind', 'lock-on', 'endure', 'swagger', 'sleep-talk', 'return', 'frustration', 'pain-split', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'facade', 'trick', 'magic-coat', 'recycle', 'secret-power', 'signal-beam', 'aerial-ace', 'shock-wave', 'gravity', 'natural-gift', 'last-resort', 'magnet-rise', 'giga-impact', 'zen-headbutt', 'trick-room', 'discharge', 'charge-beam', 'wonder-room', 'psyshock', 'foul-play', 'round', 'electroweb', 'confide'], 'name': 'porygon', 'stats': {'hp': 65, 'attack': 60, 'defense': 70, 'special-attack': 85, 'special-defense': 75, 'speed': 40}, 'types': ['normal'], 'weight': 365, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 45, 'color': 'pink', 'shape': 'legs', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ポリゴン', 'roomaji': 'Porygon', 'ko': '폴리곤', 'zh-Hant': '多邊獸', 'fr': 'Porygon', 'de': 'Porygon', 'es': 'Porygon', 'it': 'Porygon', 'en': 'Porygon', 'ja': 'ポリゴン', 'zh-Hans': '多边兽'}, 'genera': {'ja-Hrkt': 'バーチャルポケモン', 'ko': '가상포켓몬', 'zh-Hant': '虛擬寶可夢', 'fr': 'Pokémon Virtuel', 'de': 'Virtuell', 'es': 'Pokémon Virtual', 'it': 'Pokémon Virtuale', 'en': 'Virtual Pokémon', 'ja': 'バーチャルポケモン', 'zh-Hans': '虚拟宝可梦'}}
	public class SpeciePorygon : PokemonSpecie
	{
#nullable enable
		private static SpeciePorygon? _instance = null;
#nullable restore
        public static SpeciePorygon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePorygon();
                }
                return _instance;
            }
        }

		public SpeciePorygon() : base(
			"Porygon",
			65, // HPs
			60, 70, // Attack & Defense
			85, 75, // Special Attack & Defense
			40			
		) {}
	}


	//Porygon Pokemon Class
	public class Porygon : Pokemon
	{

		public Porygon(string nickname, int level) : base(
			137,
			SpeciePorygon.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public Porygon() : base(
			137,
			SpeciePorygon.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}