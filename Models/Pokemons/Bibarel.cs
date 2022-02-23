using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bibarel Specie to store common natural stats of every {'abilities': ['simple', 'unaware', 'moody'], 'base_experience': 144, 'height': 10, 'id': 400, 'moves': ['swords-dance', 'cut', 'headbutt', 'tackle', 'take-down', 'growl', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'double-team', 'defense-curl', 'waterfall', 'swift', 'amnesia', 'rest', 'hyper-fang', 'super-fang', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mud-slap', 'icy-wind', 'endure', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'shadow-ball', 'rock-smash', 'whirlpool', 'facade', 'focus-punch', 'taunt', 'superpower', 'yawn', 'secret-power', 'dive', 'covet', 'shock-wave', 'water-pulse', 'natural-gift', 'pluck', 'fling', 'last-resort', 'aqua-tail', 'giga-impact', 'rock-climb', 'captivate', 'stealth-rock', 'grass-knot', 'charge-beam', 'aqua-jet', 'round', 'echoed-voice', 'scald', 'retaliate', 'bulldoze', 'work-up', 'rototiller', 'confide'], 'name': 'bibarel', 'stats': {'hp': 79, 'attack': 85, 'defense': 60, 'special-attack': 55, 'special-defense': 60, 'speed': 71}, 'types': ['normal', 'water'], 'weight': 315, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 127, 'color': 'brown', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['water1', 'ground'], 'names': {'ja-Hrkt': 'ビーダル', 'roomaji': 'Beadull', 'ko': '비버통', 'zh-Hant': '大尾狸', 'fr': 'Castorno', 'de': 'Bidifas', 'es': 'Bibarel', 'it': 'Bibarel', 'en': 'Bibarel', 'ja': 'ビーダル', 'zh-Hans': '大尾狸'}, 'genera': {'ja-Hrkt': 'ビーバーポケモン', 'ko': '비버포켓몬', 'zh-Hant': '河狸寶可夢', 'fr': 'Pokémon Castor', 'de': 'Biber', 'es': 'Pokémon Castor', 'it': 'Pokémon Castoro', 'en': 'Beaver Pokémon', 'ja': 'ビーバーポケモン', 'zh-Hans': '河狸宝可梦'}}
	public class SpecieBibarel : PokemonSpecie
	{
#nullable enable
		private static SpecieBibarel? _instance = null;
#nullable restore
        public static SpecieBibarel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBibarel();
                }
                return _instance;
            }
        }

		public SpecieBibarel() : base(
			"Bibarel",
			79, // HPs
			85, 60, // Attack & Defense
			55, 60, // Special Attack & Defense
			71			
		) {}
	}


	//Bibarel Pokemon Class
	public class Bibarel : Pokemon
	{

		public Bibarel(string nickname, int level) : base(
			400,
			SpecieBibarel.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance, Water.Instance			
		) {}

		public Bibarel() : base(
			400,
			SpecieBibarel.Instance, // Pokemon Specie
			Normal.Instance, Water.Instance			
		) {}
	}
}