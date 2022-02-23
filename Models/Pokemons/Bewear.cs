using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bewear Specie to store common natural stats of every {'abilities': ['fluffy', 'klutz', 'unnerve'], 'base_experience': 175, 'height': 21, 'id': 760, 'moves': ['swords-dance', 'bind', 'tackle', 'take-down', 'thrash', 'double-edge', 'leer', 'roar', 'hyper-beam', 'earthquake', 'toxic', 'double-team', 'bide', 'rest', 'rock-slide', 'substitute', 'flail', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'hidden-power', 'facade', 'taunt', 'superpower', 'brick-break', 'rock-tomb', 'aerial-ace', 'dragon-claw', 'bulk-up', 'hammer-arm', 'payback', 'fling', 'focus-blast', 'giga-impact', 'shadow-claw', 'low-sweep', 'round', 'bulldoze', 'work-up', 'confide', 'baby-doll-eyes', 'brutal-swing'], 'name': 'bewear', 'stats': {'hp': 120, 'attack': 125, 'defense': 80, 'special-attack': 55, 'special-defense': 60, 'speed': 60}, 'types': ['normal', 'fighting'], 'weight': 1350, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 70, 'color': 'pink', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'キテルグマ', 'ko': '이븐곰', 'zh-Hant': '穿著熊', 'fr': 'Chelours', 'de': 'Kosturso', 'es': 'Bewear', 'it': 'Bewear', 'en': 'Bewear', 'ja': 'キテルグマ', 'zh-Hans': '穿着熊'}, 'genera': {'ja-Hrkt': 'ごうわんポケモン', 'ko': '강한완력포켓몬', 'zh-Hant': '強臂寶可夢', 'fr': 'Pokémon Biscoteaux', 'de': 'Kraftarme', 'es': 'Pokémon Brazo Fuerte', 'it': 'Pokémon Fortebraccio', 'en': 'Strong Arm Pokémon', 'ja': 'ごうわんポケモン', 'zh-Hans': '强臂宝可梦'}}
	public class SpecieBewear : PokemonSpecie
	{
#nullable enable
		private static SpecieBewear? _instance = null;
#nullable restore
        public static SpecieBewear Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBewear();
                }
                return _instance;
            }
        }

		public SpecieBewear() : base(
			"Bewear",
			120, // HPs
			125, 80, // Attack & Defense
			55, 60, // Special Attack & Defense
			60			
		) {}
	}


	//Bewear Pokemon Class
	public class Bewear : Pokemon
	{

		public Bewear(string nickname, int level) : base(
			760,
			SpecieBewear.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance, Fighting.Instance			
		) {}

		public Bewear() : base(
			760,
			SpecieBewear.Instance, // Pokemon Specie
			Normal.Instance, Fighting.Instance			
		) {}
	}
}