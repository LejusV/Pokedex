using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Porygon2 Specie to store common natural stats of every {'abilities': ['trace', 'download', 'analytic'], 'base_experience': 180, 'height': 6, 'id': 233, 'moves': ['tackle', 'double-edge', 'ice-beam', 'blizzard', 'psybeam', 'hyper-beam', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'agility', 'mimic', 'double-team', 'recover', 'defense-curl', 'swift', 'dream-eater', 'flash', 'rest', 'conversion', 'tri-attack', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'conversion-2', 'protect', 'zap-cannon', 'icy-wind', 'lock-on', 'endure', 'swagger', 'sleep-talk', 'return', 'frustration', 'pain-split', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'facade', 'trick', 'magic-coat', 'recycle', 'secret-power', 'signal-beam', 'aerial-ace', 'shock-wave', 'gravity', 'natural-gift', 'last-resort', 'magnet-rise', 'giga-impact', 'zen-headbutt', 'trick-room', 'discharge', 'charge-beam', 'wonder-room', 'psyshock', 'foul-play', 'round', 'electroweb', 'confide'], 'name': 'porygon2', 'stats': {'hp': 85, 'attack': 80, 'defense': 90, 'special-attack': 105, 'special-defense': 95, 'speed': 60}, 'types': ['normal'], 'weight': 325, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 45, 'color': 'red', 'shape': 'legs', 'habitat': 'urban', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ポリゴン２', 'roomaji': 'Porygon2', 'ko': '폴리곤2', 'zh-Hant': '多邊獸２', 'fr': 'Porygon2', 'de': 'Porygon2', 'es': 'Porygon2', 'it': 'Porygon2', 'en': 'Porygon2', 'ja': 'ポリゴン２', 'zh-Hans': '多边兽２'}, 'genera': {'ja-Hrkt': 'バーチャルポケモン', 'ko': '가상포켓몬', 'zh-Hant': '虛擬寶可夢', 'fr': 'Pokémon Virtuel', 'de': 'Virtuell', 'es': 'Pokémon Virtual', 'it': 'Pokémon Virtuale', 'en': 'Virtual Pokémon', 'ja': 'バーチャルポケモン', 'zh-Hans': '虚拟宝可梦'}}
	public class SpeciePorygon2 : PokemonSpecie
	{
#nullable enable
		private static SpeciePorygon2? _instance = null;
#nullable restore
        public static SpeciePorygon2 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePorygon2();
                }
                return _instance;
            }
        }

		public SpeciePorygon2() : base(
			"Porygon2",
			85, // HPs
			80, 90, // Attack & Defense
			105, 95, // Special Attack & Defense
			60			
		) {}
	}


	//Porygon2 Pokemon Class
	public class Porygon2 : Pokemon
	{

		public Porygon2(string nickname, int level)
		: base(
				233,
				SpeciePorygon2.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Porygon2(int level)
		: base(
				233,
				SpeciePorygon2.Instance, // Pokemon Specie
				"Porygon2", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Porygon2() : base(
			233,
			SpeciePorygon2.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}